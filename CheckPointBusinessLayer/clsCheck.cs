using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsCheck
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int CheckID { get; set; }
        public int GroupID { get; set; }
        public DateTime CheckedDate { get; set; }

        public clsGroup GroupInfo { get; set; }

        public clsCheck()
        {
            this.CheckID = -1;
            this.GroupID = -1;
            this.CheckedDate = DateTime.Now;

            Mode = enMode.AddNew;
        }

        private clsCheck(int CheckID, int GroupID, DateTime CheckedDate)
        {
            this.CheckID = CheckID;
            this.GroupID = GroupID;
            this.CheckedDate = CheckedDate;
            this.GroupInfo = clsGroup.FindByID(GroupID);

            Mode = enMode.Update;
        }

        public static DataTable LoadAllChecks(bool OrderByDate = true)
        {
            return clsCheckData.GetAllChecks(OrderByDate);
        }

        public static clsCheck FindByID(int CheckID)
        {
            int GroupID = -1;
            DateTime CheckedDate = DateTime.MinValue;

            if (clsCheckData.GetCheckByID(CheckID, ref GroupID, ref CheckedDate))
                return new clsCheck(CheckID, GroupID, CheckedDate);
            else
                return null;
        }

        public static DataTable GetChecksByGroupID(int GroupID)
        {
            return clsCheckData.GetChecksByGroupID(GroupID);
        }

        private bool _AddNew()
        {
            this.CheckID = clsCheckData.AddNewCheck(this.GroupID, this.CheckedDate);

            return this.CheckID != -1;
        }

        private bool _Update()
        {
            return clsCheckData.UpdateCheck(this.CheckID, this.GroupID, this.CheckedDate);
        }

        public bool Save()
        {
            bool Result = Mode == enMode.AddNew ? _AddNew() : _Update();

            if (Mode == enMode.AddNew && Result)
                Mode = enMode.Update;

            return Result;
        }

        public static bool Delete(int CheckID)
        {
            return clsCheckData.DeleteCheck(CheckID);
        }

        public bool Delete()
        {
            return clsCheckData.DeleteCheck(this.CheckID);
        }

        public static bool DeleteChecksByGroupID(int GroupID)
        {
            return clsCheckData.DeleteChecksByGroupID(GroupID);
        }

        public static clsCheck GetLastCheck()
        {
            int CheckID = -1;
            int GroupID = -1;
            DateTime CheckedDate = DateTime.MinValue;

            if (clsCheckData.GetLastCheck(ref CheckID, ref GroupID, ref CheckedDate))
                return new clsCheck(CheckID, GroupID, CheckedDate);
            else
                return null;
        }

        public static clsCheck GetLastCheckForGroup(int GroupID)
        {
            int CheckID = -1;
            DateTime CheckedDate = DateTime.MinValue;

            if (clsCheckData.GetLastCheckForGroup(GroupID, ref CheckID, ref CheckedDate))
                return new clsCheck(CheckID, GroupID, CheckedDate);
            else
                return null;
        }

        public static int GetCheckCountByGroupID(int GroupID)
        {
            return clsCheckData.GetCheckCountByGroupID(GroupID);
        }

        public static DataTable GetChecksByDateRange(DateTime StartDate, DateTime EndDate)
        {
            return clsCheckData.GetChecksByDateRange(StartDate, EndDate);
        }

        public static clsCheck CreateNewCheckForGroup(int GroupID)
        {
            clsCheck NewCheck = new clsCheck
            {
                GroupID = GroupID,
                CheckedDate = DateTime.Now
            };

            return NewCheck;
        }

        public static clsCheck AddNewCheckNow(int GroupID)
        {
            int CheckID = clsCheckData.AddNewCheckNow(GroupID);

            if (CheckID != -1)
                return FindByID(CheckID);
            else
                return null;
        }

        public static bool HasChecks(int GroupID)
        {
            return GetCheckCountByGroupID(GroupID) > 0;
        }
    

    }
}
