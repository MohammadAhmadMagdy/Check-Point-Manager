using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clsUserDataAccess
    {
        public static DataTable GetAllActiveUsers()
        {
            DataTable dt = new DataTable();

            string Query = "SELECT UserID, UserName FROM Users WHERE IsActive = 1 ORDER BY UserName";

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
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            string Query = @"SELECT 
                    UserID, 
                    UserName, 
                    CASE 
                        WHEN IsActive = 1 THEN 'Yes' 
                        ELSE 'No' 
                    END AS ActiveStatus 
                 FROM Users 
                 ORDER BY UserID;";

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

        public static bool GetUserByID(int UserID, ref string UserName, ref string Password, ref bool IsActive)
        {
            bool IsFound = false;

            string Query = "SELECT * FROM Users WHERE UserID = @UserID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@UserID", UserID);

                using (var Reader = Command.ExecuteReader())
                {
                    if (Reader.Read())
                    {
                        IsFound = true;

                        UserName = Reader["UserName"].ToString();
                        Password = Reader["Password"] == DBNull.Value ? "" : Reader["Password"].ToString();
                        IsActive = Convert.ToInt32(Reader["IsActive"]) == 1;
                    }
                }
            }

            return IsFound;
        }

        public static int AddNewUser(string UserName, string Password, bool IsActive)
        {
            try
            {
                int UserID = -1;

                string Query = @"INSERT INTO Users (UserName, Password, IsActive)
                                 VALUES (@UserName, @Password, @IsActive);
                                 SELECT last_insert_rowid();";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserName", UserName);
                    Command.Parameters.AddWithValue("@Password",
                        string.IsNullOrEmpty(Password) ? (object)DBNull.Value : Password);
                    Command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);

                    var Result = Command.ExecuteScalar();

                    if (Result != null && int.TryParse(Result.ToString(), out int InsertedID))
                        UserID = InsertedID;
                }

                return UserID;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return -1;
            }
        }

        public static bool UpdateUser(int UserID, string UserName, string Password, bool IsActive)
        {
            try
            {
                int AffectedRows = 0;

                string Query = @"UPDATE Users 
                                 SET UserName = @UserName, Password = @Password, IsActive = @IsActive
                                 WHERE UserID = @UserID";

                using (var Connection = clsDataAccessSettings.GetConnection())
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserID", UserID);
                    Command.Parameters.AddWithValue("@UserName", UserName);
                    Command.Parameters.AddWithValue("@Password",
                        string.IsNullOrEmpty(Password) ? (object)DBNull.Value : Password);
                    Command.Parameters.AddWithValue("@IsActive", IsActive ? 1 : 0);

                    AffectedRows = Command.ExecuteNonQuery();
                }

                return AffectedRows > 0;
            }
            catch (SQLiteException ex) when (ex.ResultCode == SQLiteErrorCode.Constraint)
            {
                return false;
            }
        }

        public static bool DoesUserNameExist(string UserName)
        {
            bool IsFound = false;

            string Query = @"SELECT 1 FROM Users
                             WHERE UserName = @UserName
                             LIMIT 1;";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@UserName", UserName);

                var Result = Command.ExecuteScalar();

                IsFound = (Result != null);
            }

            return IsFound;
        }
        public static bool Delete(int UserID)
        {
            int RowsAffected = 0;

            string Query = @"DELETE FROM Users WHERE UserID = @UserID";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@UserID", UserID);

                    RowsAffected = Command.ExecuteNonQuery();
                }
            }

            return RowsAffected > 0;
        }
        public static bool IsAParticipantInChecks(int UserID)
        {
            bool IsFound = false;

            string Query = @"SELECT EXISTS
                             (SELECT 1 FROM Checks WHERE CheckedByUserID = @UserID)
                             As IsExists;";

            using (var Connection = clsDataAccessSettings.GetConnection())
            using (var Command = new SQLiteCommand(Query, Connection))
            {
                Command.Parameters.AddWithValue("@UserID", UserID);

                var Result = Command.ExecuteScalar();

                IsFound = (Result != null);
            }

            return IsFound;
        }
    }
}
