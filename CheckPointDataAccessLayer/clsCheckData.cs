using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clsCheckData
    {
        public static DataTable GetAllChecks(bool OrderByDate = true)
        {
            DataTable dt = new DataTable();

            string Order = OrderByDate ? "CheckedDate DESC" : "CheckID";

            string Query = $@"SELECT Checks.CheckID, Checks.GroupID, Groups.GroupNumber, Groups.GroupName, Checks.CheckedDate
                             FROM Checks 
                             INNER JOIN Groups ON Checks.GroupID = Groups.GroupID 
                             ORDER BY {Order}";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                        dt.Load(Reader);
                }
            }

            return dt;
        }

        public static bool GetCheckByID(int CheckID, ref int GroupID, ref DateTime CheckedDate)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Checks WHERE CheckID = @CheckID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@CheckID", CheckID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        GroupID = Convert.ToInt32(Reader["GroupID"]);
                        CheckedDate = Reader["CheckedDate"] == DBNull.Value ? DateTime.MinValue :
                            Convert.ToDateTime(Reader["CheckedDate"]);
                    }
                }
            }

            return IsFound;
        }

        public static DataTable GetChecksByGroupID(int GroupID)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT Checks.CheckID, Checks.GroupID, Groups.GroupNumber, Groups.GroupName, Checks.CheckedDate
                            FROM Checks 
                            INNER JOIN Groups ON Checks.GroupID = Groups.GroupID
                            WHERE Checks.GroupID = @GroupID 
                            ORDER BY CheckedDate DESC";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                        dt.Load(Reader);
                }
            }

            return dt;
        }

        public static int AddNewCheck(int GroupID, DateTime CheckedDate)
        {
            try
            {
                int CheckID = -1;

                string Query = @"INSERT INTO Checks (GroupID, CheckedDate)
                                VALUES (@GroupID, @CheckedDate);
                                SELECT last_insert_rowid();";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@GroupID", GroupID);
                    Command.Parameters.AddWithValue("@CheckedDate", CheckedDate);

                    var Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    {
                        CheckID = InsertedID;
                    }
                }

                return CheckID;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return -1;
            }
        }

        public static int AddNewCheckNow(int GroupID)
        {
            return AddNewCheck(GroupID, DateTime.Now);
        }

        public static bool UpdateCheck(int CheckID, int GroupID, DateTime CheckedDate)
        {
            try
            {
                int AffectedRows = 0;

                string Query = @"UPDATE Checks 
                                SET GroupID = @GroupID, 
                                    CheckedDate = @CheckedDate 
                                WHERE CheckID = @CheckID";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@CheckID", CheckID);
                    Command.Parameters.AddWithValue("@GroupID", GroupID);
                    Command.Parameters.AddWithValue("@CheckedDate", CheckedDate);

                    AffectedRows = Command.ExecuteNonQuery();
                }

                return AffectedRows > 0;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return false;
            }
        }

        public static bool DeleteCheck(int CheckID)
        {
            int AffectedRows = 0;

            string Query = @"DELETE FROM Checks 
                            WHERE CheckID = @CheckID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@CheckID", CheckID);

                AffectedRows = Command.ExecuteNonQuery();
            }

            return AffectedRows > 0;
        }

        public static bool DeleteChecksByGroupID(int GroupID)
        {
            int AffectedRows = 0;

            string Query = @"DELETE FROM Checks 
                            WHERE GroupID = @GroupID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                AffectedRows = Command.ExecuteNonQuery();
            }

            return AffectedRows > 0;
        }

        public static bool GetLastCheck(ref int CheckID, ref int GroupID, ref DateTime CheckedDate)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Checks 
                            ORDER BY CheckedDate DESC 
                            LIMIT 1";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        CheckID = Convert.ToInt32(Reader["CheckID"]);
                        GroupID = Convert.ToInt32(Reader["GroupID"]);
                        CheckedDate = Reader["CheckedDate"] == DBNull.Value ? DateTime.MinValue :
                            Convert.ToDateTime(Reader["CheckedDate"]);
                    }
                }
            }

            return IsFound;
        }

        public static bool GetLastCheckForGroup(int GroupID, ref int CheckID, ref DateTime CheckedDate)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Checks 
                            WHERE GroupID = @GroupID 
                            ORDER BY CheckedDate DESC 
                            LIMIT 1";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        CheckID = Convert.ToInt32(Reader["CheckID"]);
                        CheckedDate = Reader["CheckedDate"] == DBNull.Value ? DateTime.MinValue :
                            Convert.ToDateTime(Reader["CheckedDate"]);
                    }
                }
            }

            return IsFound;
        }

        public static int GetCheckCountByGroupID(int GroupID)
        {
            int Count = 0;

            string Query = @"SELECT COUNT(*) FROM Checks 
                            WHERE GroupID = @GroupID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                var Result = Command.ExecuteScalar();

                if (Result != null && int.TryParse(Result.ToString(), out int CheckCount))
                {
                    Count = CheckCount;
                }
            }

            return Count;
        }

        public static DataTable GetChecksByDateRange(DateTime StartDate, DateTime EndDate)
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT Checks.*, Groups.GroupName, Groups.GroupNumber 
                            FROM Checks 
                            INNER JOIN Groups ON Checks.GroupID = Groups.GroupID 
                            WHERE CheckedDate BETWEEN @StartDate AND @EndDate 
                            ORDER BY CheckedDate DESC";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@StartDate", StartDate);
                Command.Parameters.AddWithValue("@EndDate", EndDate);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.HasRows)
                        dt.Load(Reader);
                }
            }

            return dt;
        }
    }
}
