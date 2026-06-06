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
        public int CheckedByUserID {  get; set; }
        public clsUser UserInfo {  get; set; }
        public clsGroup GroupInfo { get; set; }

        public clsCheck()
        {
            this.CheckID = -1;
            this.GroupID = -1;
            this.CheckedDate = DateTime.Now;
            this.CheckedByUserID = -1;

            Mode = enMode.AddNew;
        }

        private clsCheck(int CheckID, int GroupID, DateTime CheckedDate, int CheckedByUserID)
        {
            this.CheckID = CheckID;
            this.GroupID = GroupID;
            this.CheckedDate = CheckedDate;
            this.CheckedByUserID = CheckedByUserID;
            this.UserInfo = clsUser.FindByID(CheckedByUserID);
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
            int CheckedByUserID = -1;

            if (clsCheckData.GetCheckByID(CheckID, ref GroupID, ref CheckedDate, ref CheckedByUserID))
                return new clsCheck(CheckID, GroupID, CheckedDate, CheckedByUserID);
            else
                return null;
        }

        public static DataTable GetChecksByGroupID(int GroupID)
        {
            return clsCheckData.GetChecksByGroupID(GroupID);
        }

        private bool _AddNew()
        {
            this.CheckID = clsCheckData.AddNewCheck(this.GroupID, this.CheckedDate, 
                clsUser.Current?.UserID?? -1);

            return this.CheckID != -1;
        }

        private bool _Update()
        {
            return clsCheckData.UpdateCheck(this.CheckID, this.GroupID, this.CheckedDate, this.CheckedByUserID);
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
            int CheckedByUserID = -1;

            if (clsCheckData.GetLastCheck(ref CheckID, ref GroupID, ref CheckedDate, ref CheckedByUserID))
                return new clsCheck(CheckID, GroupID, CheckedDate, CheckedByUserID);
            else
                return null;
        }

        public static clsCheck GetLastCheckForGroup(int GroupID)
        {
            int CheckID = -1;
            DateTime CheckedDate = DateTime.MinValue;
            int CheckedByUserID = -1;

            if (clsCheckData.GetLastCheckForGroup(GroupID, ref CheckID, ref CheckedDate, ref CheckedByUserID))
                return new clsCheck(CheckID, GroupID, CheckedDate, CheckedByUserID);
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
                CheckedDate = DateTime.Now,
                CheckedByUserID = clsUser.Current?.UserID ?? -1
            };

            return NewCheck;
        }

        public static clsCheck AddNewCheckNow(int GroupID)
        {
            int CheckID = clsCheckData.AddNewCheckNow(GroupID, clsUser.Current?.UserID?? -1);

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
