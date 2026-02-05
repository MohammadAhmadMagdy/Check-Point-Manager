using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentFormat.OpenXml.Spreadsheet;

namespace CheckPointDataAccessLayer
{
    public class clsGroupData
    {
        public static DataTable GetAllGroups(bool Alphabetical = false)
        {
            DataTable dt = new DataTable();

            string Order = Alphabetical ? "GroupName" : "GroupNumber";

            string Query = $"SELECT * FROM Groups ORDER BY {Order}";

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
        public static bool GetGroupByID(int GroupID, ref int GroupNumber, ref string GroupName, 
            ref int CheckCounter, ref DateTime LastCheckDate)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Groups WHERE GroupID = @GroupID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        GroupName = Reader["GroupName"].ToString();
                        GroupNumber = Convert.ToInt32(Reader["GroupNumber"]);
                        CheckCounter = Convert.ToInt32(Reader["CheckCounter"]);
                        LastCheckDate = Reader["LastCheckDate"] == DBNull.Value ? DateTime.MinValue :
                            Convert.ToDateTime(Reader["LastCheckDate"]);
                    }
                }
            }

            return IsFound;
        }
        public static bool GetGroupByNumber(int GroupNumber, ref int GroupID, ref string GroupName, 
            ref int CheckCounter, ref DateTime LastCheckDate)
        {
            bool IsFound = false;

            string Query = @"SELECT * FROM Groups WHERE GroupNumber = @GroupNumber";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupNumber", GroupNumber);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        GroupName = Reader["GroupName"].ToString();
                        GroupID = Convert.ToInt32(Reader["GroupID"]);
                        CheckCounter = Convert.ToInt32(Reader["CheckCounter"]);
                        LastCheckDate = Reader["LastCheckDate"] == DBNull.Value ? DateTime.MinValue :
                            Convert.ToDateTime(Reader["LastCheckDate"]);
                    }
                }
            }

            return IsFound;
        }
        public static bool GetGroupByName(string GroupName, ref int GroupID, ref int GroupNumber, 
            ref int CheckCounter, ref DateTime LastCheckDate)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Groups WHERE GroupName = @GroupName";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupName", GroupName);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        GroupID = Convert.ToInt32(Reader["GroupID"]);
                        GroupNumber = Convert.ToInt32(Reader["GroupNumber"]);
                        CheckCounter = Convert.ToInt32(Reader["CheckCounter"]);
                        LastCheckDate = Reader["LastCheckDate"] == DBNull.Value ? DateTime.MinValue :
                            Convert.ToDateTime(Reader["LastCheckDate"]);
                    }
                }
            }

            return IsFound;
        }
        public static int AddNewGroup(int GroupNumber, string GroupName, int CheckCounter)
        {
            try
            {
                int GroupID = -1;

                string Query = @"INSERT INTO Groups (GroupNumber, GroupName, CheckCounter)
                             VALUES (@GroupNumber, @GroupName, @CheckCounter);
                             SELECT last_insert_rowid();";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@GroupNumber", GroupNumber);
                    Command.Parameters.AddWithValue("@GroupName", GroupName);
                    Command.Parameters.AddWithValue("@CheckCounter", CheckCounter);

                    var Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                    {
                        GroupID = InsertedID;
                    }
                }

                return GroupID;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return -1;
            }
        }
        public static bool UpdateGroup(int GroupID, int GroupNumber, string GroupName, int CheckCounter)
        {
            try
            {
                int AffectedRows = 0;

                string Query = @"UPDATE Groups SET GroupNumber = @GroupNumber , GroupName = @GroupName ,
                                                   CheckCounter = @CheckCounter 
                             WHERE GroupID = @GroupID";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@GroupID", GroupID);
                    Command.Parameters.AddWithValue("@GroupNumber", GroupNumber);
                    Command.Parameters.AddWithValue("@GroupName", GroupName);
                    Command.Parameters.AddWithValue("@CheckCounter", CheckCounter);

                    AffectedRows = Command.ExecuteNonQuery();
                }

                return AffectedRows > 0;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return false;
            }
        }
        public static bool DeleteGroupByID(int GroupID)
        {
            int AffectedRows = 0;

            string Query = @"DELETE FROM Groups 
                             WHERE GroupID = @GroupID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupID", GroupID);

                AffectedRows = Command.ExecuteNonQuery();
            }

            return AffectedRows > 0;
        }
        public static bool DeleteGroupByNumber(int GroupNumber)
        {
            int AffectedRows = 0;

            string Query = @"DELETE FROM Groups 
                             WHERE GroupNumber = @GroupNumber";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupNumber", GroupNumber);

                AffectedRows = Command.ExecuteNonQuery();
            }

            return AffectedRows > 0;
        }
        public static bool DoesGroupNumberExist(int GroupNumber)
        {
            bool IsFound = false;

            string Query = @"SELECT 1 FROM Groups
                             WHERE GroupNumber = @GroupNumber
                             LIMIT 1;";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@GroupNumber", GroupNumber);

                var Result = Command.ExecuteScalar();

                IsFound = (Result != null);
            }

            return IsFound;
        }
        public static int GetLastGroupNumber()
        {
            int GroupNumber = -1;

            string Query = @"SELECT GroupNumber
                             FROM Groups
                             ORDER by GroupNumber DESC
                             LIMIT 1 OFFSET 1;";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query,Connection))
            {
                var Result = Command.ExecuteScalar();

                if(Result == null || Result == DBNull.Value)
                {
                    return 1;
                }
                if(!int.TryParse(Result.ToString(), out GroupNumber))
                {
                    return 1;
                }
            }

            return GroupNumber;
        }
        public static bool CounterPlus(int GroupID)
        {
            try
            {
                int RowsAffected = 0;

                string Query = @"UPDATE Groups
                                   SET CheckCounter = CheckCounter + 1 
                                   WHERE GroupID = @GroupID;";

                using (var Connection = clsDataAccessSettings.GetConnection())
                {
                    using (var Command = new SQLiteCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@GroupID", GroupID);

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }

                return RowsAffected > 0;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return false;
            }
        }
        public static bool CounterMinus(int GroupID)
        {
            try
            {
                int RowsAffected = 0;

                string Query = @"UPDATE Groups
                                   SET CheckCounter = CheckCounter - 1 
                                   WHERE GroupID = @GroupID;";

                using (var Connection = clsDataAccessSettings.GetConnection())
                {
                    using (var Command = new SQLiteCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@GroupID", GroupID);

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }

                return RowsAffected > 0;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return false;
            }
        }
        public static bool CounterReset(int GroupID)
        {
            try
            {
                int RowsAffected = 0;

                string Query = @"UPDATE Groups
                                   SET CheckCounter = 0  
                                   WHERE GroupID = @GroupID;";

                using (var Connection = clsDataAccessSettings.GetConnection())
                {
                    using (var Command = new SQLiteCommand(Query, Connection))
                    {
                        Command.Parameters.AddWithValue("@GroupID", GroupID);

                        RowsAffected = Command.ExecuteNonQuery();
                    }
                }

                return RowsAffected > 0;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return false;
            }
        }
        public static bool GetLastCheckedGroup(ref int GroupID, ref int GroupNumber, ref string GroupName,
            ref int CheckCounter, ref DateTime LastCheckDate)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Groups ORDER BY LastCheckDate DESC LIMIT 1;";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(Query,Connection))
                {
                    using (var Reader = Command.ExecuteReader())
                    {
                        if(Reader.Read())
                        {
                            IsFound = true;

                            GroupID = Convert.ToInt32(Reader["GroupID"]);
                            GroupName = Reader["GroupName"].ToString();
                            GroupNumber = Convert.ToInt32(Reader["GroupNumber"]);
                            CheckCounter = Convert.ToInt32(Reader["CheckCounter"]);
                            LastCheckDate = Reader["LastCheckDate"] == DBNull.Value ? DateTime.MinValue :
                                Convert.ToDateTime(Reader["LastCheckDate"]);

                        }
                    }
                }
            }

            return IsFound;
        }
        public static bool RecordGroupCheckDate(int GroupID)
        {
            DateTime LastCheckDate = DateTime.Now;

            string Query = "UPDATE Groups SET LastCheckDate = @LastCheckDate WHERE GroupID = @GroupID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@GroupID", GroupID);
                    Command.Parameters.AddWithValue("@LastCheckDate", LastCheckDate);
                    return Command.ExecuteNonQuery() > 0;
                }
            }
        }

    }
}
