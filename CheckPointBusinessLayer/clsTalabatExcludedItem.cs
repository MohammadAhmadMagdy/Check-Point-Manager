using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsTalabatExcludedItem
    {
        public static DataTable GetAllExcludedItemCodes()
        {
            
            return clsTalabatExcludedItemData.GetAllExcludedItemCodes();
        }

      
        public static bool AddToExcludedItems(int itemCode)
        {
            return clsTalabatExcludedItemData.AddToExcludedItems(itemCode);
        }

       
        public static bool RemoveFromExcludedItems(int itemCode)
        {
            return clsTalabatExcludedItemData.RemoveFromExcludedItems(itemCode);
        }
    }
}
