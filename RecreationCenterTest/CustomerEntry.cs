using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace RecreationCenterTest
{
    [Serializable()]
    public class CustomerEntry : ISerializable
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan InTime { get; set; }
        public TimeSpan OutTime { get; set; }
        public double TotalMinutes { get; set; }
        public string Day { get; set; }
        public int Price { get; set; }
        public string CustomerType { get; set; }
        /*public int TotalRevenue { get; set; }*/


        [NonSerialized] public double Count;

        public CustomerEntry() { }

        //needed for serialization
        public static string KEY = "customerId";
        public static string KEY1 = "customerName";
        public static string KEY2 = "date";
        public static string KEY3 = "inTime";
        public static string KEY4 = "outTime";
        public static string KEY5 = "totalMinutes";
        public static string KEY6 = "day";
        public static string KEY7 = "Price";
        public static string KEY8 = "customerType";
      /*  public static string KEY9 = "totalRevenue";*/


        //CONSTRUCTOR FOR DESERIALIZATION
        public CustomerEntry(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties

            CustomerId = (int)serial.GetValue(KEY, typeof(int));
            CustomerName = (string)serial.GetValue(KEY1, typeof(string));
            Date = (DateTime)serial.GetValue(KEY2, typeof(DateTime));
            InTime = (TimeSpan)serial.GetValue(KEY3, typeof(TimeSpan));
            OutTime = (TimeSpan)serial.GetValue(KEY4, typeof(TimeSpan));
            TotalMinutes = (double)serial.GetValue(KEY5, typeof(double));
            Day = (string)serial.GetValue(KEY6, typeof(string));
            Price = (int)serial.GetValue(KEY7, typeof(int));
            CustomerType = (string)serial.GetValue(KEY8, typeof(string));
            /*TotalRevenue = (int)serial.GetValue(KEY9, typeof(int));*/

        } 
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(KEY, CustomerId);
            info.AddValue(KEY1, CustomerName);
            info.AddValue(KEY2, Date);
            info.AddValue(KEY3, InTime);
            info.AddValue(KEY4, OutTime);
            info.AddValue(KEY5, TotalMinutes);
            info.AddValue(KEY6, Day);
            info.AddValue(KEY7, Price);
            info.AddValue(KEY8, CustomerType);
           /* info.AddValue(KEY9, TotalRevenue);*/

        }
        public string GetDay()
        {
            string i = Date.ToString("dddd");
            return i;
        }
        public double CalculateTotalMinutes()
        {
            var OutTime = new TimeSpan(this.OutTime.Hours, this.OutTime.Minutes, 0);
            var InTime = new TimeSpan(this.InTime.Hours, this.InTime.Minutes, 0);
            return this.OutTime.Subtract(this.InTime).TotalMinutes;
        }

        /*public int GetTotalRevenue()
        {
            List<CustomerEntry> _customerEntryDetailsList = new List<CustomerEntry>();
            this.TotalRevenue = _customerEntryDetailsList.Sum(item => item.Price);
            return this.TotalRevenue;
        }*/
    }
}
