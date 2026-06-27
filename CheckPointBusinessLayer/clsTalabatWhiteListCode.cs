using CheckPointDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointBusinessLayer
{
    public class clsTalabatWhiteListCode
    {
        // 1. استدعاء قائمة الأكواد المسموحة
        public static DataTable GetAllIncludedItemCodes()
        {
            return clsTalabatWhiteListCodeDataAccess.GetAllIncludedItemCodes();
        }

        // 2. دالة ميكانيكية لإضافة كود جديد عبر الـ BL
        public static bool AddToWhiteList(int itemCode)
        {
            return clsTalabatWhiteListCodeDataAccess.AddToWhiteList(itemCode);
        }

        // 3. دالة ميكانيكية لحذف كود من القائمة عبر الـ BL
        public static bool RemoveFromWhiteList(int itemCode)
        {
            return clsTalabatWhiteListCodeDataAccess.RemoveFromWhiteList(itemCode);
        }
    }
}
