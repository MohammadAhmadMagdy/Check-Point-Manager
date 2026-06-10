using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace CheckPointDataAccessLayer
{
    public class clsCustomerOrderDataAccess
    {
        // ─── Importing Data ─────────────────────────────────────────────────

        public struct ImportOrdersResult
        {
            public int CustomersAdded;
            public int OrdersAdded;
            public int OrdersSkipped;

            public ImportOrdersResult(int customersAdded, int ordersAdded, int ordersSkipped)
            {
                CustomersAdded = customersAdded;
                OrdersAdded = ordersAdded;
                OrdersSkipped = ordersSkipped;
            }
        }

        public static ImportOrdersResult ImportOrdersFromExcel(string ExcelPath, int CreatedByUserID)
        {
            string tempFile = null;
            tempFile = Path.GetTempFileName() + Path.GetExtension(ExcelPath);
            File.Copy(ExcelPath, tempFile, overwrite: true);

            var WorkBook = new XLWorkbook(tempFile);
            var WorkSheet = WorkBook.Worksheet(1);

            int CustomersAdded = 0;
            int OrdersAdded = 0;
            int OrdersSkipped = 0;

            int StartRow = 2; // الصف الأول هو Header
            int LastRow = WorkSheet.LastRowUsed().RowNumber();
            int RowIndex = StartRow;

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Transaction = Connection.BeginTransaction())
            {
                try
                {
                    

                    

                    for (RowIndex = StartRow; RowIndex <= LastRow; RowIndex++)
                    {
                        var Row = WorkSheet.Row(RowIndex);

                        if (Row.IsEmpty())
                        {
                            continue;
                        }

                        // ── قراءة بيانات الصف ──────────────────────────────────
                        string PhoneNumber = Row.Cell(9).GetValue<string>().Trim();
                        string CustomerName = Row.Cell(8).GetValue<string>().Trim();
                        string StaffName = Row.Cell(6).GetValue<string>().Trim();
                        string ItemCodeRow = Row.Cell(1).GetValue<string>().Trim();
                        string ItemDescription = Row.Cell(2).GetValue<string>().Trim();

                        if (!int.TryParse(ItemCodeRow,out int ItemCode)|| ItemCode <= 0)
                        {
                            OrdersSkipped++;
                            continue;
                        }

                        if(string.IsNullOrWhiteSpace(PhoneNumber) ||
                            !PhoneNumber.All(char.IsDigit) ||
                            PhoneNumber.Length < 8 ||
                            PhoneNumber.Length > 15)
                        {
                            OrdersSkipped++;
                            continue;
                        }

                        if (string.IsNullOrWhiteSpace(CustomerName))
                            CustomerName = "Unknown";


                        int RowCreatedByUserID = string.IsNullOrEmpty(StaffName)
                             ? CreatedByUserID 
                             : clsUserDataAccess.GetUserIDByName(StaffName);

                        if (RowCreatedByUserID == -1)
                            RowCreatedByUserID = CreatedByUserID;

                        // ── البحث عن العميل بالهاتف أو إضافته ─────────────────
                        int CustomerID = _GetOrCreateCustomer(Connection, Transaction,
                                             PhoneNumber, CustomerName,
                                             RowCreatedByUserID, ref CustomersAdded);

                        if (CustomerID == -1)
                        {
                            OrdersSkipped++;
                            continue;
                        }

                        // ── تحقق من وجود طلب نشط (Status = 0 أو 1) ────────────
                        if (_ActiveOrderExists(Connection, Transaction, CustomerID, ItemCode))
                        {
                            OrdersSkipped++;
                            continue;
                        }

                        // ── إضافة الطلب الجديد ──────────────────────────────────
                        _InsertOrder(Connection, Transaction, CustomerID, ItemCode, ItemDescription,
                                     DateTime.Now, RowCreatedByUserID);
                        OrdersAdded++;
                    }

                    Transaction.Commit();
                }
                catch(Exception ex)
                {
                    Transaction.Rollback();
                    throw new Exception($"Error at Row {RowIndex}:{ex.Message}",ex);
                }
                finally
                {

                    if (tempFile != null && File.Exists(tempFile))
                        File.Delete(tempFile);
                }
            }

            return new ImportOrdersResult(CustomersAdded, OrdersAdded, OrdersSkipped);
        }

        // ── Private Helpers ────────────────────────────────────────────────────────

        private static int _GetOrCreateCustomer(SQLiteConnection Connection, SQLiteTransaction Transaction,
            string PhoneNumber, string CustomerName, int CreatedByUserID, ref int CustomersAdded)
        {
            // البحث أولاً
            string SelectQuery = "SELECT CustomerID FROM Customers WHERE PhoneNumber = @PhoneNumber";

            using (var Command = new SQLiteCommand(SelectQuery, Connection, Transaction))
            {
                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                var Result = Command.ExecuteScalar();

                if (Result != null)
                    return Convert.ToInt32(Result); // موجود مسبقاً
            }

            // غير موجود — أضفه
            string InsertQuery = @"INSERT INTO Customers (CustomerName, PhoneNumber, CreatedDate, CreatedByUserID)
                           VALUES (@CustomerName, @PhoneNumber, @CreatedDate, @CreatedByUserID);
                           SELECT last_insert_rowid();";

            using (var Command = new SQLiteCommand(InsertQuery, Connection, Transaction))
            {
                Command.Parameters.AddWithValue("@CustomerName",
                    string.IsNullOrEmpty(CustomerName) ? "Unknown" : CustomerName);
                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                Command.Parameters.AddWithValue("@CreatedDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID == -1
                                                                    ? (object)DBNull.Value : CreatedByUserID);

                var Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int NewID))
                {
                    CustomersAdded++;
                    return NewID;
                }
            }

            return -1;
        }

        private static bool _ActiveOrderExists(SQLiteConnection Connection, SQLiteTransaction Transaction,
            int CustomerID, int ItemCode)
        {
            string Query = @"SELECT 1 FROM CustomerOrders
                     WHERE CustomerID = @CustomerID
                       AND ItemCode   = @ItemCode
                       AND Status     IN (0, 1)
                     LIMIT 1";

            using (var Command = new SQLiteCommand(Query, Connection, Transaction))
            {
                Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);

                return Command.ExecuteScalar() != null;
            }
        }

        private static void _InsertOrder(SQLiteConnection Connection, SQLiteTransaction Transaction,
            int CustomerID, int ItemCode, string ItemDescription, DateTime OrderDate, int CreatedByUserID)
        {
            string Query = @"INSERT INTO CustomerOrders 
                         (CustomerID, ItemCode, ItemDescription, OrderDate, Status, CreatedByUserID)
                     VALUES 
                         (@CustomerID, @ItemCode, @ItemDescription, @OrderDate, 0, @CreatedByUserID)";

            using (var Command = new SQLiteCommand(Query, Connection, Transaction))
            {
                Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                Command.Parameters.AddWithValue("@ItemDescription", string.IsNullOrWhiteSpace(ItemDescription)
                                                             ? (object)DBNull.Value : ItemDescription);
                Command.Parameters.AddWithValue("@OrderDate", OrderDate.ToString("yyyy-MM-dd HH:mm:ss"));
                Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID == -1
                                                                    ? (object)DBNull.Value : CreatedByUserID);
                Command.ExecuteNonQuery();
            }
        }

        // ─── Reading ────────────────────────────────────────────────────────

        public static DataTable GetAllOrders()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                                 CustomerOrders.OrderID,
                                 CustomerOrders.CustomerID,
                                 Customers.CustomerName,
                                 Customers.PhoneNumber,
                                 CustomerOrders.ItemCode,
                                 COALESCE(Items.Description, CustomerOrders.ItemDescription, 'Unknown')  AS ItemDescription,
                                 COALESCE(Items.Qty,   0)  AS CurrentQty,
                                 COALESCE(Items.LzQty, 0)  AS CurrentLzQty, 
                                 CustomerOrders.OrderDate, 
                                 CASE 
                                     WHEN CustomerOrders.Status = 0 THEN 'Not Available' 
                                     WHEN CustomerOrders.Status = 1 THEN 'Available Now' 
                                     WHEN CustomerOrders.Status = 2 THEN 'Notified' END  AS Status,
                                 CustomerOrders.AvailableDate,
                                 CustomerOrders.NotifiedDate,
                                 CustomerOrders.CreatedByUserID,
                                 Users.UserName      AS CreatedByUserName
                             FROM CustomerOrders
                             INNER JOIN Customers ON CustomerOrders.CustomerID = Customers.CustomerID
                             LEFT JOIN Items     ON CustomerOrders.ItemCode   = Items.ItemCode
                             LEFT  JOIN Users     ON CustomerOrders.CreatedByUserID = Users.UserID
                             ORDER BY CustomerOrders.OrderDate DESC";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            using (var Adapter = new SQLiteDataAdapter(Command))
            {
                Adapter.Fill(dt);
            }

            return dt;
        }

        public static DataTable GetOrdersByCustomerID(int CustomerID)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                         CustomerOrders.OrderID,
                         CustomerOrders.CustomerID,
                         Customers.CustomerName,
                         Customers.PhoneNumber,
                         CustomerOrders.ItemCode,
                         COALESCE(Items.Description, CustomerOrders.ItemDescription, 'Unknown') AS ItemDescription,
                         COALESCE(Items.Qty,   0) AS CurrentQty, 
                         COALESCE(Items.LzQty, 0) AS CurrentLzQty,
                         CustomerOrders.OrderDate,
                         CASE 
                             WHEN CustomerOrders.Status = 0 THEN 'Not Available' 
                             WHEN CustomerOrders.Status = 1 THEN 'Available Now' 
                             WHEN CustomerOrders.Status = 2 THEN 'Notified' 
                         END AS Status,
                         CustomerOrders.AvailableDate,
                         CustomerOrders.NotifiedDate,
                         CustomerOrders.CreatedByUserID,
                         Users.UserName AS CreatedByUserName
                     FROM CustomerOrders
                     INNER JOIN Customers ON CustomerOrders.CustomerID = Customers.CustomerID
                     LEFT  JOIN Items     ON CustomerOrders.ItemCode   = Items.ItemCode  
                     LEFT  JOIN Users     ON CustomerOrders.CreatedByUserID = Users.UserID
                     WHERE CustomerOrders.CustomerID = @CustomerID
                     ORDER BY CustomerOrders.OrderDate DESC";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                using (var Adapter = new SQLiteDataAdapter(Command))
                {
                    Adapter.Fill(dt);
                }
            }

            return dt;
        }
        
        // ★ هذه الميثود هي القلب المستقبلي لخاصية الواتساب ★
        // ترجع كل الطلبات التي أصبح الصنف متوفراً (Status = 1)
        // وتشمل رقم هاتف العميل واسم الصنف — جاهزة للإرسال مباشرة
        public static DataTable GetAvailableOrders()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                         CustomerOrders.OrderID,
                         CustomerOrders.CustomerID,
                         Customers.CustomerName,
                         Customers.PhoneNumber,
                         CustomerOrders.ItemCode,
                         COALESCE(Items.Description, CustomerOrders.ItemDescription, 'Unknown') AS ItemDescription, 
                         COALESCE(Items.Qty,   0) AS CurrentQty,  
                         COALESCE(Items.LzQty, 0) AS CurrentLzQty,
                         CustomerOrders.OrderDate,
                         CustomerOrders.AvailableDate
                     FROM CustomerOrders
                     INNER JOIN Customers ON CustomerOrders.CustomerID = Customers.CustomerID
                     LEFT  JOIN Items     ON CustomerOrders.ItemCode   = Items.ItemCode 
                     WHERE CustomerOrders.Status = 1
                     ORDER BY CustomerOrders.AvailableDate DESC";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            using (var Adapter = new SQLiteDataAdapter(Command))
            {
                Adapter.Fill(dt);
            }

            return dt;
        }

        public static bool GetOrderByID(int OrderID, ref int CustomerID, ref int ItemCode, ref string ItemDescription,
            ref DateTime OrderDate, ref int Status, ref DateTime AvailableDate,
            ref DateTime NotifiedDate, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM CustomerOrders WHERE OrderID = @OrderID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@OrderID", OrderID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        CustomerID = Convert.ToInt32(Reader["CustomerID"]);
                        ItemCode = Convert.ToInt32(Reader["ItemCode"]);
                        OrderDate = Convert.ToDateTime(Reader["OrderDate"]);
                        Status = Convert.ToInt32(Reader["Status"]);
                        AvailableDate = Reader["AvailableDate"] == DBNull.Value ? DateTime.MinValue
                                          : Convert.ToDateTime(Reader["AvailableDate"]);
                        NotifiedDate = Reader["NotifiedDate"] == DBNull.Value ? DateTime.MinValue
                                          : Convert.ToDateTime(Reader["NotifiedDate"]);
                        CreatedByUserID = Reader["CreatedByUserID"] == DBNull.Value ? -1
                                          : Convert.ToInt32(Reader["CreatedByUserID"]);
                    }
                }
            }

            return IsFound;
        }

        // ─── Writing ────────────────────────────────────────────────────────

        public static int AddNewOrder(int CustomerID, int ItemCode, DateTime OrderDate, int CreatedByUserID)
        {
            try
            {
                int OrderID = -1;

                string Query = @"INSERT INTO CustomerOrders 
                                     (CustomerID, ItemCode, OrderDate, Status, CreatedByUserID)
                                 VALUES 
                                     (@CustomerID, @ItemCode, @OrderDate, 0, @CreatedByUserID);
                                 SELECT last_insert_rowid();";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                    Command.Parameters.AddWithValue("@OrderDate", OrderDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID == -1
                                                                        ? (object)DBNull.Value : CreatedByUserID);

                    var Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        OrderID = InsertedID;
                }

                return OrderID;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return -1;
            }
        }

        // ★ تُستدعى تلقائياً من clsItemDataAccess عند تحديث المخزون ★
        // تضع Status = 1 وتسجل تاريخ التوفر — لاحقاً ستُطلق الإشعار
        public static int MarkOrdersAsAvailable(SQLiteConnection Connection, SQLiteTransaction Transaction,
            int ItemCode)
        {
            string Query = @"UPDATE CustomerOrders
                             SET Status        = 1,
                                 AvailableDate = @AvailableDate
                             WHERE ItemCode = @ItemCode
                               AND Status   = 0";

            using (var Command = new SQLiteCommand(Query, Connection, Transaction))
            {
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                Command.Parameters.AddWithValue("@AvailableDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                return Command.ExecuteNonQuery();
            }
        }

        // ★ تُستدعى بعد إرسال الواتساب لاحقاً ★
        public static bool MarkOrderAsNotified(int OrderID)
        {
            string Query = @"UPDATE CustomerOrders
                             SET Status       = 2,
                                 NotifiedDate = @NotifiedDate
                             WHERE OrderID = @OrderID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@OrderID", OrderID);
                Command.Parameters.AddWithValue("@NotifiedDate", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));

                return Command.ExecuteNonQuery() > 0;
            }
        }

        public static bool DeleteOrder(int OrderID)
        {
            string Query = "DELETE FROM CustomerOrders WHERE OrderID = @OrderID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@OrderID", OrderID);

                return Command.ExecuteNonQuery() > 0;
            }
        }

        public static bool DoesActiveOrderExist(int CustomerID, int ItemCode)
        {
            string Query = @"SELECT 1 FROM CustomerOrders
                             WHERE CustomerID = @CustomerID
                               AND ItemCode   = @ItemCode
                               AND Status     = 0
                             LIMIT 1";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);

                return Command.ExecuteScalar() != null;
            }
        }
    }
}
