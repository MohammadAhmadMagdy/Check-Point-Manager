using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using ClosedXML;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;

namespace CheckPointDataAccessLayer
{
    public class clsItemDataAccess
    {
        public static List<int> UpdateItemsFromExcel(string ExcelPath)
        {
            var WorkBook = new XLWorkbook(ExcelPath);
            var WorkSheet = WorkBook.Worksheet(1);

            List<int> NewItems = new List<int>();

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                
                using (var Transaction = Connection.BeginTransaction())
                {
                    try
                    {
                        int StartRow = 7;
                        int LastRow = WorkSheet.LastRowUsed().RowNumber();

                        for (int RowIndex = StartRow; RowIndex <= LastRow; RowIndex++)
                        {
                            var Row = WorkSheet.Row(RowIndex);

                            int ItemCode = Row.Cell(1).GetValue<int>();
                            string Description = Row.Cell(3).GetValue<string>();
                            int Qty = Row.Cell(5).GetValue<int>();
                            int LzQty = Row.Cell(6).GetValue<int>();
                            decimal RetailPrice = Row.Cell(7).GetValue<decimal>();

                            string CheckQuery = "SELECT COUNT(*) FROM Items WHERE ItemCode = @ItemCode";

                            using (var CheckCommand =  new SQLiteCommand(CheckQuery, Connection, Transaction))
                            {
                                CheckCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                                long Count = (long)CheckCommand.ExecuteScalar();

                                if (Count > 0)
                                {
                                    string UpdateQuery = @"UPDATE Items 
                                                           SET Qty = @Qty, LzQty = @LzQty
                                                           WHERE ItemCode = @ItemCode";
                                    using (var UpdateCommand = new SQLiteCommand(UpdateQuery, Connection, Transaction))
                                    {
                                        UpdateCommand.Parameters.AddWithValue("@Qty", Qty);
                                        UpdateCommand.Parameters.AddWithValue("@LzQty", LzQty);
                                        UpdateCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                                        UpdateCommand.ExecuteNonQuery();
                                    }
                                }
                                else
                                {
                                    string InsertQuery = @"INSERT INTO Items 
                                                           (ItemCode, Description, Qty, LzQty, RetailPrice) 
                                                          VALUES (@ItemCode, @Descrition, @Qty, @LzQty, @RetailPrice)";
                                    using (var InsertCommand = new SQLiteCommand(InsertQuery, Connection, Transaction))
                                    {
                                        InsertCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                                        InsertCommand.Parameters.AddWithValue("@Description", Description);
                                        InsertCommand.Parameters.AddWithValue("@Qty", Qty);
                                        InsertCommand.Parameters.AddWithValue("@LzQty", LzQty);
                                        InsertCommand.Parameters.AddWithValue("@RetailPrice", RetailPrice);
                                        InsertCommand.ExecuteNonQuery();
                                    }

                                    NewItems.Add(ItemCode);
                                }
                            }
                        }

                        Transaction.Commit();
                    }
                    catch
                    {
                        Transaction.Rollback();
                        throw;
                    }
                }
            }

            return NewItems;
        }

        public static bool AddNewItem(int itemCode, string description, int qty, int lzQty, decimal retailPrice)
        {
            string query = @"INSERT INTO Items (ItemCode, Description, Qty, LzQty, RetailPrice)
                         VALUES (@ItemCode, @Description, @Qty, @LzQty, @RetailPrice)";

            using (var connection = clsDataAccessSettings.GetConnection())
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Qty", qty);
                command.Parameters.AddWithValue("@LzQty", lzQty);
                command.Parameters.AddWithValue("@RetailPrice", retailPrice);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool GetByItemCode(int ItemCode, ref string Description, ref int Qty, ref int LzQty, ref decimal RetailPrice)
        {
            bool IsFound = false;

            string query = "SELECT * FROM Items WHERE ItemCode = @ItemCode";

            using (var connection = clsDataAccessSettings.GetConnection())
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ItemCode", ItemCode);

                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IsFound = true;

                        ItemCode = Convert.ToInt32(reader["ItemCode"]);
                        Description = reader["Description"].ToString();
                        Qty = Convert.ToInt32(reader["Qty"]);
                        LzQty = Convert.ToInt32(reader["LzQty"]);
                        RetailPrice = Convert.ToDecimal(reader["RetailPrice"]);
                     
                    }
                }
            }

            return IsFound;
        }

        public static DataTable GetAll()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT 
                                  Items.ItemCode,
                                  Items.Description, Items.Qty, Items.LzQty, Items.RetailPrice, 
                                  IFNULL(GROUP_CONCAT(Groups.GroupName, ', '), 'Not Assigned') AS GroupName
                              FROM Items
                              LEFT JOIN ItemsGroups ON Items.ItemCode = ItemsGroups.ItemCode
                              LEFT JOIN Groups ON Groups.GroupID = ItemsGroups.GroupID
                              GROUP BY Items.ItemCode
                              ORDER BY Items.ItemCode;
                              ;";

            using (var connection = clsDataAccessSettings.GetConnection())
            using (var command = new SQLiteCommand(query, connection))
            {
                using (var reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dt.Columns.Add("Selected", typeof(bool));
                        dt.Columns["Selected"].DefaultValue = false;
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        public static bool UpdateItem(int itemCode, string description, int qty, int lzQty, decimal retailPrice)
        {
            string query = @"UPDATE Items
                         SET Description = @Description,
                             Qty = @Qty,
                             LzQty = @LzQty,
                             RetailPrice = @RetailPrice
                         WHERE ItemCode = @ItemCode";

            using (var connection = clsDataAccessSettings.GetConnection())
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);
                command.Parameters.AddWithValue("@Description", description);
                command.Parameters.AddWithValue("@Qty", qty);
                command.Parameters.AddWithValue("@LzQty", lzQty);
                command.Parameters.AddWithValue("@RetailPrice", retailPrice);

                return command.ExecuteNonQuery() > 0;
            }
        }

        public static bool Delete(int itemCode)
        {
            string query = "DELETE FROM Items WHERE ItemCode = @ItemCode";

            using (var connection = clsDataAccessSettings.GetConnection())
            using (var command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ItemCode", itemCode);

                return command.ExecuteNonQuery() > 0;
            }
        }
    }

}
