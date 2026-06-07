using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 }
        public enMode Mode = enMode.AddNew;

        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }

        public static clsUser Current { get; private set; }

        public clsUser()
        {
            this.UserID = -1;
            this.UserName = "";
            this.Password = "";
            this.IsActive = true;

            Mode = enMode.AddNew;
        }

        private clsUser(int UserID, string UserName, string Password, bool IsActive)
        {
            this.UserID = UserID;
            this.UserName = UserName;
            this.Password = Password;
            this.IsActive = IsActive;

            Mode = enMode.Update;
        }

        public static DataTable GetAllActiveUsers()
        {
            return clsUserDataAccess.GetAllActiveUsers();
        }
        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static clsUser FindByID(int UserID)
        {
            string UserName = "";
            string Password = "";
            bool IsActive = false;

            if (clsUserDataAccess.GetUserByID(UserID, ref UserName, ref Password, ref IsActive))
                return new clsUser(UserID, UserName, Password, IsActive);
            else
                return null;
        }
        public static int GetUserIDByName(string UserName)
        {
            return clsUserDataAccess.GetUserIDByName(UserName);
        }
        public static bool DoesUserNameExist(string UserName)
        {
            return clsUserDataAccess.DoesUserNameExist(UserName);
        }

        private bool _AddNew()
        {
            this.UserID = clsUserDataAccess.AddNewUser(this.UserName, this.Password, this.IsActive);

            return this.UserID != -1;
        }

        private bool _Update()
        {
            return clsUserDataAccess.UpdateUser(this.UserID, this.UserName, this.Password, this.IsActive);
        }

        public bool Save()
        {
            bool Result = Mode == enMode.AddNew ? _AddNew() : _Update();

            if (Mode == enMode.AddNew && Result)
                Mode = enMode.Update;

            return Result;
        }
        public bool Delete()
        {
            return clsUserDataAccess.Delete(this.UserID);
        }
        public static bool Delete(int UserID)
        {
            return clsUserDataAccess.Delete(UserID);
        }

        public bool IsAParticipantInChecks()
        {
            return clsUserDataAccess.IsAParticipantInChecks(this.UserID);
        }

        public static bool Login(int UserID)
        {
            clsUser User = FindByID(UserID);

            if (User == null || !User.IsActive)
                return false;

            Current = User;
            return true;
        }

        public static void Logout()
        {
            Current = null;
        }
    }
}
