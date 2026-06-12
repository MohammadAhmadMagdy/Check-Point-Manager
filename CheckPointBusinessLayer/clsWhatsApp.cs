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
        // ★ الميثود الرئيسية — الـ UI يستدعي هذه فقط
        // عند الانتقال للـ API لاحقاً — تغيير هذه الميثود فقط
        public static bool NotifyCustomer(int OrderID)
        {
            // جلب بيانات الطلب والعميل
            clsCustomerOrder Order = clsCustomerOrder.FindByID(OrderID);
            if (Order == null)
                return false;

            clsCustomer Customer = clsCustomer.FindByID(Order.CustomerID);
            if (Customer == null)
                return false;

            string ItemDescription = !string.IsNullOrWhiteSpace(Order.ItemDescription)
                                     ? Order.ItemDescription
                                     : $"Item Code: {Order.ItemCode}";

            // إرسال الإشعار
            _NotifyViaWhatsAppWeb(Customer.PhoneNumber, Customer.CustomerName, ItemDescription);

            // تسجيل أن العميل تم إبلاغه
            return clsCustomerOrderDataAccess.MarkOrderAsNotified(OrderID);
        }

        // ★ إرسال كل الطلبات المتوفرة دفعة واحدة
        // ترجع عدد الإشعارات التي تم إرسالها
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

        // ── Private ───────────────────────────────────────────────────────

        private static void _NotifyViaWhatsAppWeb(string Phone, string CustomerName, string ItemDescription)
        {
            // تأكد أن الرقم بالصيغة الدولية (عُمان 968)
            Phone = _FormatPhone(Phone);

            string Message = Uri.EscapeDataString(
                $"مرحباً {CustomerName} 👋\n" +
                $"الصنف الذي طلبته *{ItemDescription}* أصبح متوفراً الآن ✅\n" +
                $"يسعدنا خدمتك 🙏"
            );

            Process.Start(new ProcessStartInfo
            {
                FileName = $"https://api.whatsapp.com/send?phone={Phone}&text={Message}",
                UseShellExecute = true
            });
        }

        // جاهزة للمستقبل — فقط اكتب المنطق هنا عند الانتقال للـ API
        private static bool _NotifyViaAPI(string Phone, string CustomerName, string ItemDescription)
        {
            throw new NotImplementedException("API notification not implemented yet.");
        }

        private static string _FormatPhone(string Phone)
        {
            // إزالة أي مسافات أو رموز
            Phone = Phone.Trim().Replace(" ", "").Replace("-", "").Replace("+", "");

            // لو الرقم 8 أرقام (عُماني بدون كود) أضف 968
            if (Phone.Length == 8)
                Phone = "968" + Phone;

            return Phone;
        }
    }
}
