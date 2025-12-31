using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointBusinessLayer
{
    public class clsGroup
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int GroupID {  get; set; }
        public string GroupName { get; set; }

        public clsGroup()
        {
            this.GroupID = -1;
            this.GroupName = "";

            Mode = enMode.AddNew;
        }
        public clsGroup(int GroupID, string GroupName)
        {
            this.GroupID = GroupID;
            this.GroupName = GroupName;

            Mode = enMode.Update;
        }

    }
}
