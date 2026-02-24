using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckPointDataAccessLayer;

namespace CheckPointBusinessLayer
{
    public class clsSettings
    {
        public static class Keys
        {
            public const string LastStockUpdate = "LastStockUpdate";
            public const string AppVersion = "AppVersion";
        }

        public string Key { get; private set; }
        public string Value { get; private set; }

        public clsSettings(string Key, string Value)
        {
            this.Key = Key;
            this.Value = Value;
        }

        public static string GetValue(string Key, string DefaultValue = "" )
        {
            if (string.IsNullOrWhiteSpace(Key))
                return DefaultValue;

            string Result = clSettingsData.GetValue(Key);

            return Result ?? DefaultValue;
        }
        public static bool SetValue(string Key, string Value)
        {
            if (string.IsNullOrWhiteSpace(Key))
                return false;

            return clSettingsData.SetValue(Key, Value);
        }
        public static DateTime? GetLastStockUpdate()
        {
            string val = GetValue(Keys.LastStockUpdate);

            if (string.IsNullOrEmpty(val))
                return null;

            if (DateTime.TryParse(val, out DateTime result))
                return result;

            return null;
        }
        public static bool RecordStockUpdate()
        {
            string Value = DateTime.Now.ToString();

            return SetValue(Keys.LastStockUpdate, Value);
        }
        public static string GetLastStockUpdateToDisplay()
        {
            DateTime? LastUpdate = GetLastStockUpdate();

            string LastUpdateString = LastUpdate?.ToString("ddd, dd MMM yyyy - hh:mm tt");

            return LastUpdateString ?? "Not Updated Yet";

        }

    }
}
