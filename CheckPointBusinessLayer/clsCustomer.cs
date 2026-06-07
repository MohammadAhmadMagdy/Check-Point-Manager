using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsCustomer
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string Notes { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedByUserID { get; set; }

        public clsCustomer()
        {
            this.CustomerID = -1;
            this.CustomerName = "";
            this.PhoneNumber = "";
            this.Notes = "";
            this.CreatedDate = DateTime.Now;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsCustomer(int CustomerID, string CustomerName, string PhoneNumber,
            string Notes, DateTime CreatedDate, int CreatedByUserID)
        {
            this.CustomerID = CustomerID;
            this.CustomerName = CustomerName;
            this.PhoneNumber = PhoneNumber;
            this.Notes = Notes;
            this.CreatedDate = CreatedDate;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;
        }

        public static DataTable GetAllCustomers()
        {
            return clsCustomerDataAccess.GetAllCustomers();
        }

        public static clsCustomer FindByID(int CustomerID)
        {
            string CustomerName = "";
            string PhoneNumber = "";
            string Notes = "";
            DateTime CreatedDate = DateTime.MinValue;
            int CreatedByUserID = -1;

            if (clsCustomerDataAccess.GetCustomerByID(CustomerID, ref CustomerName, ref PhoneNumber,
                    ref Notes, ref CreatedDate, ref CreatedByUserID))
                return new clsCustomer(CustomerID, CustomerName, PhoneNumber,
                    Notes, CreatedDate, CreatedByUserID);
            else
                return null;
        }

        public static clsCustomer FindByPhone(string PhoneNumber)
        {
            int CustomerID = -1;
            string CustomerName = "";
            string Notes = "";
            DateTime CreatedDate = DateTime.MinValue;
            int CreatedByUserID = -1;

            if (clsCustomerDataAccess.GetCustomerByPhone(PhoneNumber, ref CustomerID, ref CustomerName,
                    ref Notes, ref CreatedDate, ref CreatedByUserID))
                return new clsCustomer(CustomerID, CustomerName, PhoneNumber,
                    Notes, CreatedDate, CreatedByUserID);
            else
                return null;
        }

        public static bool DoesPhoneNumberExist(string PhoneNumber)
        {
            return clsCustomerDataAccess.DoesPhoneNumberExist(PhoneNumber);
        }

        private bool _AddNew()
        {
            this.CreatedDate = DateTime.Now;
            this.CreatedByUserID = clsUser.Current?.UserID ?? -1;

            this.CustomerID = clsCustomerDataAccess.AddNewCustomer(
                this.CustomerName,
                this.PhoneNumber,
                this.Notes,
                this.CreatedDate,
                this.CreatedByUserID);

            return this.CustomerID != -1;
        }

        private bool _Update()
        {
            return clsCustomerDataAccess.UpdateCustomer(
                this.CustomerID,
                this.CustomerName,
                this.PhoneNumber,
                this.Notes);
        }

        public bool Save()
        {
            bool Result = Mode == enMode.AddNew ? _AddNew() : _Update();

            if (Mode == enMode.AddNew && Result)
                Mode = enMode.Update;

            return Result;
        }

        public static bool Delete(int CustomerID)
        {
            return clsCustomerDataAccess.DeleteCustomer(CustomerID);
        }

        public bool Delete()
        {
            return clsCustomerDataAccess.DeleteCustomer(this.CustomerID);
        }
    }
}
