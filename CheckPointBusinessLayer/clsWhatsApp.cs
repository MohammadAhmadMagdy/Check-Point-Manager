using CheckPointDataAccessLayer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPointBusinessLayer
{
    public class clsWhatsApp
    {
        
        public static bool NotifyCustomer(int OrderID)
        {
            
            clsCustomerOrder Order = clsCustomerOrder.FindByID(OrderID);
            if (Order == null)
                return false;

            clsCustomer Customer = clsCustomer.FindByID(Order.CustomerID);
            if (Customer == null)
                return false;

            string ItemDescription = Order.ItemDescription;

            if (string.IsNullOrWhiteSpace(ItemDescription))
            {
                ItemDescription = Order.ItemInfo != null
                    ? Order.ItemInfo.Description
                    : "No Description Available";
            }

           
            _NotifyViaWhatsAppWeb(Customer.PhoneNumber, Customer.CustomerName, ItemDescription);

            
            return clsCustomerOrderDataAccess.MarkOrderAsNotified(OrderID);
        }

        
        public static int NotifyAllAvailable()
        {
            System.Data.DataTable AvailableOrders = clsCustomerOrder.GetAvailableOrders();

            int NotifiedCount = 0;

            foreach (System.Data.DataRow Row in AvailableOrders.Rows)
            {
                int OrderID = Convert.ToInt32(Row["OrderID"]);

                if (NotifyCustomer(OrderID))
                    NotifiedCount++;
            }

            return NotifiedCount;
        }

        

        private static void _NotifyViaWhatsAppWeb(string Phone, string CustomerName, string ItemDescription)
        {
            
            Phone = _FormatPhone(Phone);

            string Message = Uri.EscapeDataString(
                             $"🌿 *صيدلية طيبا - فرع صحار*\n\n" +
                             $"السلام عليكم {CustomerName} 👋\n\n" +
                             $"يسعدنا إخبارك بأن المنتج الذي طلبته:\n" +
                             $"📦 *{ItemDescription}*\n\n" +
                             $"أصبح متوفراً لدينا الآن.\n" +
                             $"نتطلع لخدمتكم في أقرب وقت.\n\n" +
                             $"━━━━━━━━━━━━━━━━━━\n\n" +
                             $"🌿 *Taiba Pharmacy - Sohar Branch*\n\n" +
                             $"Dear {CustomerName},\n\n" +
                             $"We're pleased to inform you that the item you requested:\n" +
                             $"📦 *{ItemDescription}*\n\n" +
                             $"is now available in our pharmacy.\n" +
                             $"We look forward to serving you soon."
                            );

            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://api.whatsapp.com/send?phone={Phone}&text={Message}",
                UseShellExecute = true
            });
        }

        
        private static bool _NotifyViaAPI(string Phone, string CustomerName, string ItemDescription)
        {
            throw new NotImplementedException("API notification not implemented yet.");
        }

        private static string _FormatPhone(string Phone)
        {
           
            Phone = Phone.Trim().Replace(" ", "").Replace("-", "").Replace("+", "");

            
            if (Phone.Length == 8)
                Phone = "968" + Phone;

            return Phone;
        }
    }
}
