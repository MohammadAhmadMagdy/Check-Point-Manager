using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clSettingsData
    {
        public static string GetValue(string Key)
        {
            string Value = null;

            string Query = "SELECT SettingValue FROM Settings WHERE SettingKey = @Key";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@Key", Key);

                    object Result = Command.ExecuteScalar();

                    if (Result != null && Result != DBNull.Value)
                        Value = Result.ToString();
                }
            }

            return Value;
        }
        public static bool SetValue(string Key, string Value)
        {
            string Query = @"INSERT INTO Settings (SettingKey, SettingValue)
                             VALUES (@Key, @Value)
                             ON CONFLICT(SettingKey)
                             DO UPDATE SET SettingValue = @Value";

            using (var Connection = clsDataAccessSettings.GetConnection())
            {
                using (var Command = new SQLiteCommand(Query, Connection))
                {
                    Command.Parameters.AddWithValue("@Key", Key);
                    Command.Parameters.AddWithValue("@Value", Value);

                    return Command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}
