using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointDataAccessLayer
{
    public static class clsTalabatWhiteListCodeDataAccess
    {
        // 1. دالة جلب جميع الأكواد المسموحة من الجدول كـ Integer
        public static DataTable GetAllIncludedItemCodes()
        {
            DataTable dt = new DataTable();

            // قم باستبدال نص الاتصال هذا بمتغير الاتصال العام المعتمد في مشروعك (مثال: clsDataAccessSettings.ConnectionString)
        
            string query = "SELECT ItemCode FROM TalabatWhiteList";

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
                System.Diagnostics.Debug.WriteLine("DAL Error (WhiteList): " + ex.Message);
            }

            return dt;
        }

        // 2. دالة ميكانيكية لإضافة كود جديد لقائمة السماح
        public static bool AddToWhiteList(int itemCode)
        {
            int rowsAffected = 0;

            string query = "INSERT OR IGNORE INTO TalabatWhiteList (ItemCode) VALUES (@ItemCode)";

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
                System.Diagnostics.Debug.WriteLine("DAL Error (WhiteList Insert): " + ex.Message);
            }

            return (rowsAffected > 0);
        }

        // 3. دالة ميكانيكية لحذف كود من قائمة السماح
        public static bool RemoveFromWhiteList(int itemCode)
        {
            int rowsAffected = 0;

            string query = "DELETE FROM TalabatWhiteList WHERE ItemCode = @ItemCode";

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
                System.Diagnostics.Debug.WriteLine("DAL Error (WhiteList Delete): " + ex.Message);
            }

            return (rowsAffected > 0);
        }
    }
}
