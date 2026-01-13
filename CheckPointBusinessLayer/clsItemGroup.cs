using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsItemGroup
    {
        public enum enMode { AddNew = 0, Update = 1}
        public enMode Mode = enMode.AddNew;
        public int ItemCode {  get; set; }
        public clsItem ItemInfo;
        public int GroupID {  get; set; }
        public clsGroup GroupInfo;

        public clsItemGroup()
        {
            this.ItemCode = -1;
            this.GroupID = -1;

            Mode = enMode.AddNew;
        }
        private clsItemGroup(int ItemCode, int GroupID)
        {
            this.ItemCode = ItemCode;
            this.ItemInfo = clsItem.Find(ItemCode);
            this.GroupID = GroupID;
            this.GroupInfo = clsGroup.FindByID(GroupID);

            Mode = enMode.Update;
        }
        public static int AddItemsListToGroup(List<int> ItemCodes, int GroupID)
        {
            return clsItemGroupData.AddItemsListToGroup(ItemCodes, GroupID);
        }
        public static DataTable GetGroupItemsByGroupID(int GroupID)
        {
            return clsItemGroupData.GetGroupItemsByGroupID(GroupID);
        }
        public static bool DoesItemExistsInThisGroup(int ItemCode, int GroupID)
        {
            return clsItemGroupData.DoesItemExistsInThisGroup(ItemCode, GroupID);
        }
        private bool _AddNew()
        {
            return clsItemGroupData.AddNew(this.ItemCode, this.GroupID);
        }
        private bool _Update()
        {
            return clsItemGroupData.Update(this.ItemCode, this.GroupID);
        }
        public bool Save()
        {
            bool Result = Mode == enMode.AddNew ? _AddNew() : _Update();

            if (Mode == enMode.AddNew && Result)
                Mode = enMode.Update;

            return Result;
        }
        public static bool Delete(int ItemCode, int GroupID)
        {
            return clsItemGroupData.Delete(ItemCode, GroupID);
        }
        public bool Delete()
        {
            return clsItemGroupData.Delete(this.ItemCode, this.GroupID);
        }
    }
}
