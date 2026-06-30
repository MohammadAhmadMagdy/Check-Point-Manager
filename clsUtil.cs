using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Check_Point_Manager
{
    public static class clsUtil
    {
        public static void BackupDatabaseWithAutoCleanAsync()
        {
           
            Task.Run(() =>
            {
                try
                {
                    string sourceFile = Path.Combine(Application.StartupPath, "Stock.db");
                    if (!File.Exists(sourceFile)) return;

                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string targetFolder = Path.Combine(desktopPath, @"Check Point Update\db_Backup");

                    if (!Directory.Exists(targetFolder))
                    {
                        Directory.CreateDirectory(targetFolder);
                    }

                    string timestamp = DateTime.Now.ToString("yyyy-MM-dd_HH-mm-ss");
                    string destFileName = $"Stock_Backup_{timestamp}.db";
                    string destinationFile = Path.Combine(targetFolder, destFileName);

                   
                    File.Copy(sourceFile, destinationFile, true);

              
                    DirectoryInfo directoryInfo = new DirectoryInfo(targetFolder);
                    FileInfo[] files = directoryInfo.GetFiles("Stock_Backup_*.db");
                    DateTime thresholdDate = DateTime.Now.AddDays(-3);

                    foreach (FileInfo file in files)
                    {
                        if (file.LastWriteTime < thresholdDate)
                        {
                            file.Delete();
                        }
                    }
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("Backup Error: " + ex.Message);
                }
            });
        }
    }
}
