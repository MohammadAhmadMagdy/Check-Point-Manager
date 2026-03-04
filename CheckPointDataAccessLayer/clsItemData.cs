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
        private struct ItemData
        {
            public int ItemCode;
            public string Description;
            public int Qty;
            public int LzQty;
            public decimal RetailPrice;

            public ItemData(int code, string desc, int q, int lz, decimal price)
            {
                ItemCode = code; Description = desc; Qty = q; LzQty = lz; RetailPrice = price;
            }
        }

        public static int UpdateItemsFromExcel(string ExcelPath)
        {
            var WorkBook = new XLWorkbook(ExcelPath);
            var WorkSheet = WorkBook.Worksheet(1);

            int addedToNewlyAddedCount = 0;

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Transaction = Connection.BeginTransaction())
                {
                    try
                    {
                        int StartRow = 7;
                        int LastRow = WorkSheet.LastRowUsed().RowNumber();

                     
                        var itemsToAddToNewlyAdded = new List<ItemData>();

                        for (int RowIndex = StartRow; RowIndex <= LastRow; RowIndex++)
                        {
                            var Row = WorkSheet.Row(RowIndex);

                            int ItemCode = Row.Cell(1).GetValue<int>();
                            string Description = Row.Cell(3).GetValue<string>();
                            int Qty = Row.Cell(5).GetValue<int>();
                            int LzQty = Row.Cell(6).GetValue<int>();
                            decimal RetailPrice = Row.Cell(7).GetValue<decimal>();

                            string CheckQuery = "SELECT Qty, LzQty FROM Items WHERE ItemCode = @ItemCode";
                            bool isNewItem = false;
                            bool wasZeroQty = false;

                            using (var CheckCommand = new SQLiteCommand(CheckQuery, Connection, Transaction))
                            {
                                CheckCommand.Parameters.AddWithValue("@ItemCode", ItemCode);
                                using (var reader = CheckCommand.ExecuteReader())
                                {
                                    if (reader.Read())
                                    {
                                        int currentQty = Convert.ToInt32(reader["Qty"]);
                                        int currentLzQty = Convert.ToInt32(reader["LzQty"]);
                                        if (currentQty == 0 && currentLzQty == 0) wasZeroQty = true;
                                    }
                                    else
                                    {
                                        isNewItem = true;
                                    }
                                }
                            }

                            if (isNewItem)
                            {
                                
                                InsertItemIntoDatabase(Connection, Transaction, ItemCode, Description, Qty, LzQty, 
                                    RetailPrice);

                                itemsToAddToNewlyAdded.Add(new ItemData(ItemCode, Description, Qty, LzQty, RetailPrice));
                            }
                            else
                            {
                                
                                UpdateItemInDatabase(Connection, Transaction, ItemCode, Description, Qty, LzQty, 
                                    RetailPrice);

                                
                                if (wasZeroQty && (Qty > 0 || LzQty > 0))
                                {
                                    string GroupCheckQuery = "SELECT COUNT(*) FROM ItemsGroups WHERE ItemCode = " +
                                        "@ItemCode";
                                    using (var GroupCheckCmd = new SQLiteCommand(GroupCheckQuery, Connection, Transaction))
                                    {
                                        GroupCheckCmd.Parameters.AddWithValue("@ItemCode", ItemCode);
                                        if ((long)GroupCheckCmd.ExecuteScalar() == 0)
                                        {
                                            itemsToAddToNewlyAdded.Add(new ItemData(ItemCode, Description, Qty, LzQty, 
                                                RetailPrice));
                                        }
                                    }
                                }
                            }
                        }

                        
                        if (itemsToAddToNewlyAdded.Count > 0)
                        {
                           
                            //string DeleteQuery = "DELETE FROM NewlyAddedItems";
                            //using (var DeleteCmd = new SQLiteCommand(DeleteQuery, Connection, Transaction))
                            //{
                            //    DeleteCmd.ExecuteNonQuery();
                            //}

                            
                            foreach (var item in itemsToAddToNewlyAdded)
                            {
                                AddToNewlyAddedItems(Connection, Transaction, item.ItemCode, item.Description, 
                                    item.Qty, item.LzQty, item.RetailPrice);
                                addedToNewlyAddedCount++;
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

            return addedToNewlyAddedCount;
        }

        private static void InsertItemIntoDatabase(SQLiteConnection conn, SQLiteTransaction trans,
            int code, string desc, int q, int lz, decimal price)
        {
            string query = "INSERT INTO Items (ItemCode, Description, Qty, LzQty, RetailPrice) VALUES " +
                "(@ItemCode, @Description, @Qty, @LzQty, @RetailPrice)";
            using (var cmd = new SQLiteCommand(query, conn, trans))
            {
                cmd.Parameters.AddWithValue("@ItemCode", code);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@Qty", q);
                cmd.Parameters.AddWithValue("@LzQty", lz);
                cmd.Parameters.AddWithValue("@RetailPrice", price);
                cmd.ExecuteNonQuery();
            }
        }

        private static void UpdateItemInDatabase(SQLiteConnection conn, SQLiteTransaction trans, int code, string desc,
            int q, int lz, decimal price)
        {
            string query = "UPDATE Items SET Description = @Description, Qty = @Qty, LzQty = @LzQty, RetailPrice = " +
                "@RetailPrice WHERE ItemCode = @ItemCode";
            using (var cmd = new SQLiteCommand(query, conn, trans))
            {
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@Qty", q);
                cmd.Parameters.AddWithValue("@LzQty", lz);
                cmd.Parameters.AddWithValue("@RetailPrice", price);
                cmd.Parameters.AddWithValue("@ItemCode", code);
                cmd.ExecuteNonQuery();
            }
        }
        private static void AddToNewlyAddedItems(SQLiteConnection conn, SQLiteTransaction trans, int code, 
            string desc, int q, int lz, decimal price)
        {
            string query = "INSERT INTO NewlyAddedItems (ItemCode, Description, Qty, LzQty, RetailPrice) " +
                "VALUES (@ItemCode, @Description, @Qty, @LzQty, @RetailPrice)";
            using (var cmd = new SQLiteCommand(query, conn, trans))
            {
                cmd.Parameters.AddWithValue("@ItemCode", code);
                cmd.Parameters.AddWithValue("@Description", desc);
                cmd.Parameters.AddWithValue("@Qty", q);
                cmd.Parameters.AddWithValue("@LzQty", lz);
                cmd.Parameters.AddWithValue("@RetailPrice", price);
                cmd.ExecuteNonQuery();
            }
        }

        public static bool DeleteNewlyAddedItems()
        {
            string Query = "DELETE FROM NewlyAddedItems";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command =  new SQLiteCommand(Query, Connection))
                {
                    return Command.ExecuteNonQuery() > 0;
                }
            }
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

        public static bool GetByItemCode(int ItemCode, ref string Description, ref int Qty, ref int LzQty, ref decimal RetailPrice,
            ref int VariationQty, ref int VariationLzQty)
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
                        VariationQty = (reader["VariationQty"] != DBNull.Value) ? 
                            Convert.ToInt32(reader["VariationQty"]) : 0;
                        VariationLzQty = (reader["VariationLzQty"] != DBNull.Value) ? 
                            Convert.ToInt32(reader["VariationLzQty"]) : 0;

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
                                  IFNULL(GROUP_CONCAT(Groups.GroupName, ', '), 'Not Assigned') AS GroupName, 
                                  Items.VariationQty, Items.VariationLzQty
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
        public static DataTable GetNewlyAddedItems()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                                  NewlyAddedItems.ItemCode,
                                  NewlyAddedItems.Description, NewlyAddedItems.Qty, NewlyAddedItems.LzQty, 
                                  NewlyAddedItems.RetailPrice, 
                                  IFNULL(GROUP_CONCAT(Groups.GroupName, ', '), 'Not Assigned') AS GroupName
                              FROM NewlyAddedItems
                              LEFT JOIN ItemsGroups ON NewlyAddedItems.ItemCode = ItemsGroups.ItemCode
                              LEFT JOIN Groups ON Groups.GroupID = ItemsGroups.GroupID
                              GROUP BY NewlyAddedItems.ItemCode
                              ORDER BY NewlyAddedItems.ItemCode;
                              ;";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(Query,Connection))
                {
                    using (var Reader = Command.ExecuteReader())
                    {
                        if (Reader.HasRows)
                        {
                            dt.Columns.Add("Selected", typeof(bool));
                            dt.Columns["Selected"].DefaultValue = false;
                            dt.Load(Reader);
                        }
                    }
                }
            }

            return dt;
        }
        //public static DataTable GetNotAssignedWithPositiveStockItems()
        //{

        //}

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

        public static bool UpdateItemVariation(int ItemCode, int VariationQty, int VariationLzQty)
        {
            string query = @"UPDATE Items
                             SET VariationQty = @VariationQty,
                                 VariationLzQty = @VariationLzQty
                             WHERE ItemCode = @ItemCode";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                    Command.Parameters.AddWithValue("@VariationQty", VariationQty);
                    Command.Parameters.AddWithValue("@VariationLzQty", VariationLzQty);
                    return Command.ExecuteNonQuery() > 0;
                }
            }
        }
        public static DataTable GetAllVariations()
        {
            DataTable dt = new DataTable();

            string query = @"SELECT 
                                  Items.ItemCode,
                                  Items.Description, Items.Qty, Items.LzQty, Items.RetailPrice, 
                                  Items.VariationQty, Items.VariationLzQty, 
                                  IFNULL(GROUP_CONCAT(Groups.GroupName, ', '), 'Not Assigned') AS GroupName 
                                  
                              FROM Items
                              LEFT JOIN ItemsGroups ON Items.ItemCode = ItemsGroups.ItemCode
                              LEFT JOIN Groups ON Groups.GroupID = ItemsGroups.GroupID
                              WHERE Items.VariationQty <> 0 OR Items.VariationLzQty <> 0
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
                        //dt.Columns.Add("Selected", typeof(bool));
                        //dt.Columns["Selected"].DefaultValue = false;
                        dt.Load(reader);
                    }
                }
            }

            return dt;
        }

        public static bool SettleItemVariation(int ItemCode)
        {
            string query = @"UPDATE Items
                             SET VariationQty = 0,
                                 VariationLzQty = 0
                             WHERE ItemCode = @ItemCode";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(query, Connection))
                {
                    Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                    return Command.ExecuteNonQuery() > 0;
                }
            }
        }
    }

}
