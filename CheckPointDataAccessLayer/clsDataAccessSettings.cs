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
        private static string _ConnectionString = @"Data Source=Stock.db";



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
