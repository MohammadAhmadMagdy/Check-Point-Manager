using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Office2010.Excel;

namespace CheckPointDataAccessLayer
{
    public class clsItemGroupData
    {
        public static DataTable GetGroupItemsByGroupID(int GroupID)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT Items.ItemCode, Items.Description, Items.Qty, Items.LzQty, Items.RetailPrice
                                    From Items 
                                    INNER JOIN ItemsGroups ON Items.ItemCode = ItemsGroups.ItemCode
		                            WHERE GroupID = @GroupID;";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                    {
                        dt.Load(Reader);
                    }
                }
            }

            return dt;
        }
        public static bool GetItemGroupByItemCode(int ItemCode, ref int GroupID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM ItemsGroups WHERE ItemCode = @ItemCode";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);

                using (var reader = Command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IsFound = true;

                        GroupID = Convert.ToInt32(reader["GroupID"]);
                    }
                }
            }

            return IsFound;
        }
        public static bool GetItemGroupByGroupID(ref int ItemCode, int GroupID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM ItemsGroups WHERE GroupID = @GroupID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                using (var reader = Command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        IsFound = true;

                        ItemCode = Convert.ToInt32(reader["ItemCode"]);
                    }
                }
            }

            return IsFound;
        }
        public static bool AddNew(int ItemCode, int GroupID)
        {
            string Query = @"INSERT INTO ItemsGroups (ItemCode, GroupID) 
                             VALUES (@ItemCode, @GroupID)";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                try
                {
                    return Command.ExecuteNonQuery() > 0;
                }
                catch (SQLiteException ex)
                {
                    if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                        return false;

                    throw;
                }
            }
        }
        public static int AddItemsListToGroup(List<int> ItemCodes , int GroupID)
        {
            int TotalInserted = 0;

            if (ItemCodes == null || ItemCodes.Count == 0)
                return 0;

            string Query = @"INSERT OR IGNORE INTO ItemsGroups (GroupID, ItemCode) 
                             VALUES (@GroupID, @ItemCode)";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Transaction = Connection.BeginTransaction())
            using (var Command = new SQLiteCommand(Query, Connection, Transaction))
            {
                Command.Parameters.AddWithValue("@GroupID", DbType.Int32);
                Command.Parameters.AddWithValue("@ItemCode", DbType.Int32);

                Command.Parameters["@GroupID"].Value = GroupID;

                foreach (var IC in ItemCodes)
                {
                    Command.Parameters["@ItemCode"].Value = IC;
                    TotalInserted += Command.ExecuteNonQuery();
                }

                Transaction.Commit();
            }

            return TotalInserted;
        }
        public static bool Update(int ItemCode, int GroupID)
        {
            string Query = @"UPDATE ItemsGroups
                             SET GroupID = @GroupID 
                             WHERE ItemCode = @ItemCode";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                try
                {
                    return Command.ExecuteNonQuery() > 0;
                }
                catch (SQLiteException ex)
                {
                    if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                        return false;

                    throw;
                }
            }
        }
        public static bool Delete(int ItemCode, int GroupID)
        {
            string Query = @"DELETE FROM ItemsGroups 
                             WHERE ItemCode = @ItemCode AND GroupID = @GroupID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@ItemCode", ItemCode);
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                try
                {
                    return Command.ExecuteNonQuery() > 0;
                }
                catch (SQLiteException ex)
                {
                    if (ex.ErrorCode == (int)SQLiteErrorCode.Constraint)
                        return false;

                    throw;
                }
            }
        }
    }
}
