using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clsITemGroupData
    {
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
            string Query = @"DELETE FROM ItemsCodes 
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
