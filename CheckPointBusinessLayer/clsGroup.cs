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

        public clsGroup()
        {
            this.GroupID = -1;
            this.GroupNumber = -1;
            this.GroupName = "";

            Mode = enMode.AddNew;
        }
        private clsGroup(int GroupID, int GroupNumber, string GroupName)
        {
            this.GroupID = GroupID;
            this.GroupNumber = GroupNumber;
            this.GroupName = GroupName;

            Mode = enMode.Update;
        }
        public static DataTable LoadAllGroupsInfo()
        {
            return clsGroupData.GetAllGroups();
        }
        public static clsGroup FindByID(int GroupID)
        {
            int GroupNumber = -1;
            string GroupName = "";

            if (clsGroupData.GetGroupByID(GroupID, ref GroupNumber, ref GroupName))
                return new clsGroup(GroupID, GroupNumber, GroupName);
            else
                return null;
        }
        public static clsGroup FindByNumber(int GroupNumber)
        {
            int GroupID = -1;
            string GroupName = "";

            if (clsGroupData.GetGroupByNumber(GroupNumber, ref GroupID, ref GroupName))
                return new clsGroup(GroupID, GroupNumber, GroupName);
            else
                return null;
        }
        public static clsGroup FindByName(string GroupName)
        {
            int GroupID = -1;
            int GroupNumber = -1;

            if (clsGroupData.GetGroupByName(GroupName, ref GroupID, ref GroupNumber))
                return new clsGroup(GroupID, GroupNumber, GroupName);
            else
                return null;
        }
        private bool _AddNew()
        {
            this.GroupID = clsGroupData.AddNewGroup(this.GroupNumber, this.GroupName);

            return this.GroupID != -1;
        }
        private bool _Update()
        {
            return clsGroupData.UpdateGroup(this.GroupID, this.GroupNumber, this.GroupName);
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
    }
}
