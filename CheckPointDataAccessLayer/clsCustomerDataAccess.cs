using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clsCustomerDataAccess
    {
        public static DataTable GetAllCustomers()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                                 Customers.CustomerID,
                                 Customers.CustomerName,
                                 Customers.PhoneNumber,
                                 Customers.Notes,
                                 Customers.CreatedDate,
                                 Customers.CreatedByUserID,
                                 Users.UserName AS CreatedByUserName
                             FROM Customers
                             LEFT JOIN Users ON Customers.CreatedByUserID = Users.UserID
                             ORDER BY Customers.CustomerID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            using (var Adapter = new SQLiteDataAdapter(Command))
            {
                Adapter.Fill(dt);
            }

            return dt;
        }

        public static bool GetCustomerByID(int CustomerID, ref string CustomerName, ref string PhoneNumber,
            ref string Notes, ref DateTime CreatedDate, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Customers WHERE CustomerID = @CustomerID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        CustomerName = Reader["CustomerName"].ToString();
                        PhoneNumber = Reader["PhoneNumber"].ToString();
                        Notes = Reader["Notes"] == DBNull.Value ? "" : Reader["Notes"].ToString();
                        CreatedDate = Convert.ToDateTime(Reader["CreatedDate"]);
                        CreatedByUserID = Reader["CreatedByUserID"] == DBNull.Value ? -1
                                          : Convert.ToInt32(Reader["CreatedByUserID"]);
                    }
                }
            }

            return IsFound;
        }
        public static bool GetCustomerByPhone(string PhoneNumber, ref int CustomerID, ref string CustomerName,
    ref string Notes, ref DateTime CreatedDate, ref int CreatedByUserID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Customers WHERE PhoneNumber = @PhoneNumber";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        CustomerID = Convert.ToInt32(Reader["CustomerID"]);
                        CustomerName = Reader["CustomerName"].ToString();
                        Notes = Reader["Notes"] == DBNull.Value ? "" : Reader["Notes"].ToString();
                        CreatedDate = Convert.ToDateTime(Reader["CreatedDate"]);
                        CreatedByUserID = Reader["CreatedByUserID"] == DBNull.Value ? -1
                                          : Convert.ToInt32(Reader["CreatedByUserID"]);
                    }
                }
            }

            return IsFound;
        }


        public static int AddNewCustomer(string CustomerName, string PhoneNumber, string Notes,
            DateTime CreatedDate, int CreatedByUserID)
        {
            try
            {
                int CustomerID = -1;

                string Query = @"INSERT INTO Customers (CustomerName, PhoneNumber, Notes, CreatedDate, CreatedByUserID)
                                 VALUES (@CustomerName, @PhoneNumber, @Notes, @CreatedDate, @CreatedByUserID);
                                 SELECT last_insert_rowid();";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerName", CustomerName);
                    Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    Command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes)
                                                                        ? (object)DBNull.Value : Notes);
                    Command.Parameters.AddWithValue("@CreatedDate", CreatedDate.ToString("yyyy-MM-dd HH:mm:ss"));
                    Command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID == -1
                                                                        ? (object)DBNull.Value : CreatedByUserID);

                    var Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        CustomerID = InsertedID;
                }

                return CustomerID;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return -1;
            }
        }

        public static bool UpdateCustomer(int CustomerID, string CustomerName, string PhoneNumber, string Notes)
        {
            try
            {
                int AffectedRows = 0;

                string Query = @"UPDATE Customers 
                                 SET CustomerName = @CustomerName,
                                     PhoneNumber  = @PhoneNumber,
                                     Notes        = @Notes
                                 WHERE CustomerID = @CustomerID";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@CustomerID", CustomerID);
                    Command.Parameters.AddWithValue("@CustomerName", CustomerName);
                    Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    Command.Parameters.AddWithValue("@Notes", string.IsNullOrEmpty(Notes)
                                                                     ? (object)DBNull.Value : Notes);

                    AffectedRows = Command.ExecuteNonQuery();
                }

                return AffectedRows > 0;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return false;
            }
        }

        public static bool DeleteCustomer(int CustomerID)
        {
            int AffectedRows = 0;

            string Query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@CustomerID", CustomerID);

                AffectedRows = Command.ExecuteNonQuery();
            }

            return AffectedRows > 0;
        }

        public static bool DoesPhoneNumberExist(string PhoneNumber)
        {
            string Query = @"SELECT 1 FROM Customers 
                             WHERE PhoneNumber = @PhoneNumber 
                             LIMIT 1";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);

                return Command.ExecuteScalar() != null;
            }
        }

    }
}
