using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsCustomerOrder
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enum enStatus { Pending = 0, Available = 1, Notified = 2 }

        public enMode Mode = enMode.AddNew;

        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public int ItemCode { get; set; }
        public DateTime OrderDate { get; set; }
        public enStatus Status { get; set; }
        public DateTime AvailableDate { get; set; }
        public DateTime NotifiedDate { get; set; }
        public int CreatedByUserID { get; set; }

        public clsCustomerOrder()
        {
            this.OrderID = -1;
            this.CustomerID = -1;
            this.ItemCode = -1;
            this.OrderDate = DateTime.Now;
            this.Status = enStatus.Pending;
            this.AvailableDate = DateTime.MinValue;
            this.NotifiedDate = DateTime.MinValue;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsCustomerOrder(int OrderID, int CustomerID, int ItemCode, DateTime OrderDate,
            enStatus Status, DateTime AvailableDate, DateTime NotifiedDate, int CreatedByUserID)
        {
            this.OrderID = OrderID;
            this.CustomerID = CustomerID;
            this.ItemCode = ItemCode;
            this.OrderDate = OrderDate;
            this.Status = Status;
            this.AvailableDate = AvailableDate;
            this.NotifiedDate = NotifiedDate;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }

        public static DataTable GetAllOrders()
        {
            return clsCustomerOrderDataAccess.GetAllOrders();
        }

        public static DataTable GetOrdersByCustomerID(int CustomerID)
        {
            return clsCustomerOrderDataAccess.GetOrdersByCustomerID(CustomerID);
        }

        // ★ تُستدعى من شاشة التنبيهات لعرض الطلبات الجاهزة للإشعار
        public static DataTable GetAvailableOrders()
        {
            return clsCustomerOrderDataAccess.GetAvailableOrders();
        }

        public static clsCustomerOrder FindByID(int OrderID)
        {
            int CustomerID = -1;
            int ItemCode = -1;
            DateTime OrderDate = DateTime.MinValue;
            int StatusValue = 0;
            DateTime AvailableDate = DateTime.MinValue;
            DateTime NotifiedDate = DateTime.MinValue;
            int CreatedByUserID = -1;

            if (clsCustomerOrderDataAccess.GetOrderByID(OrderID, ref CustomerID, ref ItemCode,
                    ref OrderDate, ref StatusValue, ref AvailableDate,
                    ref NotifiedDate, ref CreatedByUserID))
                return new clsCustomerOrder(OrderID, CustomerID, ItemCode, OrderDate,
                    (enStatus)StatusValue, AvailableDate, NotifiedDate, CreatedByUserID);
            else
                return null;
        }

        public static bool DoesActiveOrderExist(int CustomerID, int ItemCode)
        {
            return clsCustomerOrderDataAccess.DoesActiveOrderExist(CustomerID, ItemCode);
        }

        private bool _AddNew()
        {
            this.OrderDate = DateTime.Now;
            this.CreatedByUserID = clsUser.Current?.UserID ?? -1;

            this.OrderID = clsCustomerOrderDataAccess.AddNewOrder(
                this.CustomerID,
                this.ItemCode,
                this.OrderDate,
                this.CreatedByUserID);

            return this.OrderID != -1;
        }

        public bool Save()
        {
            // الطلبات لا تُعدَّل يدوياً — فقط AddNew
            bool Result = _AddNew();

            if (Result)
                Mode = enMode.Update;

            return Result;
        }

        // ★ تُستدعى تلقائياً من clsItem عند تحديث المخزون
        // ترجع عدد الطلبات التي أصبحت متوفرة
        public static int MarkOrdersAsAvailable(
            System.Data.SQLite.SQLiteConnection Connection,
            System.Data.SQLite.SQLiteTransaction Transaction,
            int ItemCode)
        {
            return clsCustomerOrderDataAccess.MarkOrdersAsAvailable(
                Connection, Transaction, ItemCode);
        }

        // ★ تُستدعى بعد إرسال الواتساب لاحقاً
        public static bool MarkAsNotified(int OrderID)
        {
            return clsCustomerOrderDataAccess.MarkOrderAsNotified(OrderID);
        }

        public bool MarkAsNotified()
        {
            return clsCustomerOrderDataAccess.MarkOrderAsNotified(this.OrderID);
        }

        public static bool Delete(int OrderID)
        {
            return clsCustomerOrderDataAccess.DeleteOrder(OrderID);
        }

        public bool Delete()
        {
            return clsCustomerOrderDataAccess.DeleteOrder(this.OrderID);
        }

        // ★ استيراد الطلبات من Excel
        public static clsCustomerOrderDataAccess.ImportOrdersResult ImportFromExcel(string ExcelPath)
        {
            int UserID = clsUser.Current?.UserID ?? -1;
            return clsCustomerOrderDataAccess.ImportOrdersFromExcel(ExcelPath, UserID);
        }
    }
}
