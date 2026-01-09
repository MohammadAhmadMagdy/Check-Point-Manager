using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clsDataAccessSettings
    {
        private static readonly string _dbPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Stock.db");

        private static readonly string _ConnectionString = $"Data Source={_dbPath};Version=3;FailIfMissing=True;";

        public static SQLiteConnection GetConnection()
        {
            var connection = new SQLiteConnection(_ConnectionString);

            try
            {
                connection.Open();

                using (var command = new SQLiteCommand("PRAGMA foreign_keys = ON;", connection))
                {
                    command.ExecuteNonQuery();
                }

                return connection;
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException("Failed to open SQLite connection.", ex);
            }
        }

    }
}
