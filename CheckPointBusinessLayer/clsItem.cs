using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsItem
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;
        public int ItemCode {  get; set; }
        public string Description { get; set; }
        public int Qty {  get; set; }
        public int LzQty {  get; set; }
        public decimal RetailPrice {  get; set; }

        public clsItem()
        {
            this.ItemCode = -1;
            this.Description = "";
            this.Qty = 0;
            this.LzQty = 0;
            this.RetailPrice = 0;

            Mode = enMode.AddNew;
        }
        private clsItem(int ItemCode, string Description, int Qty, int LzQty, decimal RetailPrice)
        {
            this.ItemCode = ItemCode;
            this.Description = Description;
            this.Qty = Qty;
            this.LzQty = LzQty;
            this.RetailPrice = RetailPrice;

            Mode = enMode.Update;
        }

        public static List<int> UpdateStockAndGetNewItemsCodes(string ExcelPath)
        {
            return clsItemDataAccess.UpdateItemsFromExcel(ExcelPath);
        }
        public static DataTable GetAllStockList()
        {
            return clsItemDataAccess.GetAll();
        }
        public static clsItem Find(int ItemCode)
        {
            int Qty = 0, LzQty = 0;
            string Description = "";
            decimal RetailPrice = 0;

            if (clsItemDataAccess.GetByItemCode(ItemCode, ref Description, ref Qty, ref LzQty, ref RetailPrice))
            {
                return new clsItem(ItemCode, Description, Qty, LzQty, RetailPrice);
            }
            else
                return null;
        }


    }
}
