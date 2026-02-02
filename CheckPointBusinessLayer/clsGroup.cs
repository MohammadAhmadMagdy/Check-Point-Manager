using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsGroup
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int GroupID {  get; set; }
        public int GroupNumber {  get; set; }
        public string GroupName { get; set; }
        public int CheckCounter { get; set; }

        public clsGroup()
        {
            this.GroupID = -1;
            this.GroupNumber = -1;
            this.GroupName = "";
            this.CheckCounter = 0;

            Mode = enMode.AddNew;
        }
        private clsGroup(int GroupID, int GroupNumber, string GroupName, int CheckCounter)
        {
            this.GroupID = GroupID;
            this.GroupNumber = GroupNumber;
            this.GroupName = GroupName;
            this.CheckCounter = CheckCounter;

            Mode = enMode.Update;
        }
        public static DataTable LoadAllGroupsInfo(bool Alphabetical = false)
        {
            return clsGroupData.GetAllGroups(Alphabetical);
        }
        public static clsGroup FindByID(int GroupID)
        {
            int GroupNumber = -1;
            string GroupName = "";
            int CheckCounter = 0;

            if (clsGroupData.GetGroupByID(GroupID, ref GroupNumber, ref GroupName, ref CheckCounter))
                return new clsGroup(GroupID, GroupNumber, GroupName, CheckCounter);
            else
                return null;
        }
        public static clsGroup FindByNumber(int GroupNumber)
        {
            int GroupID = -1;
            string GroupName = "";
            int CheckCounter = 0;

            if (clsGroupData.GetGroupByNumber(GroupNumber, ref GroupID, ref GroupName, ref CheckCounter))
                return new clsGroup(GroupID, GroupNumber, GroupName, CheckCounter);
            else
                return null;
        }
        public static clsGroup FindByName(string GroupName)
        {
            int GroupID = -1;
            int GroupNumber = -1;
            int CheckCounter = 0;

            if (clsGroupData.GetGroupByName(GroupName, ref GroupID, ref GroupNumber, ref CheckCounter))
                return new clsGroup(GroupID, GroupNumber, GroupName, CheckCounter);
            else
                return null;
        }
        private bool _AddNew()
        {
            this.GroupID = clsGroupData.AddNewGroup(this.GroupNumber, this.GroupName, this.CheckCounter);

            return this.GroupID != -1;
        }
        private bool _Update()
        {
            return clsGroupData.UpdateGroup(this.GroupID, this.GroupNumber, this.GroupName, this.CheckCounter);
        }
        public bool Save()
        {
            bool Result = Mode == enMode.AddNew ? _AddNew() : _Update();

            if (Mode == enMode.AddNew && Result)
                Mode = enMode.Update;

            return Result;
        }
        public static bool Delete(int GroupID)
        {
            return clsGroupData.DeleteGroupByID(GroupID);
        }
        public bool Delete()
        {
            return clsGroupData.DeleteGroupByID(this.GroupID);
        }
        public static bool DeleteByGroupNumber(int GroupNumber)
        {
            return clsGroupData.DeleteGroupByNumber(GroupNumber);
        }
        public bool DeleteByGroupyNumber()
        {
            return clsGroupData.DeleteGroupByNumber(this.GroupNumber);
        }
        public static bool DoesGroupNumberExist(int GroupNumber)
        {
            return clsGroupData.DoesGroupNumberExist(GroupNumber);
        }
        public static int GetLastGroupNumber()
        {
            return clsGroupData.GetLastGroupNumber();
        }
        public static int GenerateNextGroupNumber()
        {
            int LastGroupNumber = clsGroupData.GetLastGroupNumber();
            return (LastGroupNumber > 0) ? LastGroupNumber +1 : 1;
        }
        public bool CounterPlus()
        {
            return clsGroupData.CounterPlus(this.GroupID);
        }
        public bool CounterMinus()
        {
            return clsGroupData.CounterMinus(this.GroupID);
        }
        public bool CounterReset()
        {
            return clsGroupData.CounterReset(this.GroupID);
        }
    }
}
