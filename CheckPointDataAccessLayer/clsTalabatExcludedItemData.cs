using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public class clsTalabatExcludedItemData
    {
        public static DataTable GetAllExcludedItemCodes()
        {
            DataTable dt = new DataTable();

            
            string query = "SELECT ItemCode FROM TalabatExcludedItems";

            try
            {
                using (SQLiteConnection connection = clsDataAccessSettings.GetConnection())
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                dt.Load(reader);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("DAL Error: " + ex.Message);
            }

            return dt;
        }

       
        public static bool AddToExcludedItems(int itemCode)
        {
            int rowsAffected = 0;

            string query = "INSERT INTO TalabatExcludedItems (ItemCode) VALUES (@ItemCode)";

            try
            {
                using (SQLiteConnection connection = clsDataAccessSettings.GetConnection())
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemCode", itemCode);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("DAL Error: " + ex.Message);
            }

            return (rowsAffected > 0);
        }

        
        public static bool RemoveFromExcludedItems(int itemCode)
        {
            int rowsAffected = 0;

            string query = "DELETE FROM TalabatExcludedItems WHERE ItemCode = @ItemCode";

            try
            {
                using (SQLiteConnection connection = clsDataAccessSettings.GetConnection())
                {
                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ItemCode", itemCode);

                        rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine("DAL Error: " + ex.Message);
            }

            return (rowsAffected > 0);
        }
    }
}
