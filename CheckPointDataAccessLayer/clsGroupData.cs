using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clsGroupData
    {
        private static readonly string ConnectionString = clsDataAccessSettings.ConnectionString;
        public static bool GetGroupByID(int GroupID, ref string GroupName)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Groups WHERE GroupID = @GroupID";

            using (var Connection = new SQLiteConnection(ConnectionString))
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                Connection.Open();

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        GroupName = Reader["GroupName"].ToString();
                    }
                }
            }

            return IsFound;
        }
        public static bool GetGroupByName(string GroupName, ref int GroupID)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Groups WHERE GroupName = @GroupName";

            using (var Connection = new SQLiteConnection(ConnectionString))
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupName", GroupName);

                Connection.Open();

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        GroupID = Convert.ToInt32(Reader["GroupID"]);
                    }
                }
            }

            return IsFound;
        }

    }
}
