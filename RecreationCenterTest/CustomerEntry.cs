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
        public int customerId { get; set; }
        public string customerName { get; set; }
        public DateTime date { get; set; }
        public TimeSpan inTime { get; set; }
        public TimeSpan outTime { get; set; }
        public double totalMinutes { get; set; }
        public string day { get; set; }
       /* public int Price { get; set; }*/

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
       /* public static string KEY7 = "Price";*/

        //CONSTRUCTOR FOR DESERIALIZATION
        public CustomerEntry(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties

            customerId = (int)serial.GetValue(KEY, typeof(int));
            customerName = (string)serial.GetValue(KEY1, typeof(string));
            date = (DateTime)serial.GetValue(KEY2, typeof(DateTime));
            inTime = (TimeSpan)serial.GetValue(KEY3, typeof(TimeSpan));
            outTime = (TimeSpan)serial.GetValue(KEY4, typeof(TimeSpan));
            totalMinutes = (double)serial.GetValue(KEY5, typeof(double));
            day = (string)serial.GetValue(KEY6, typeof(string));
            /*Price = (int)serial.GetValue(KEY7, typeof(int));*/
        }
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(KEY, customerId);
            info.AddValue(KEY1, customerName);
            info.AddValue(KEY2, date);
            info.AddValue(KEY3, inTime);
            info.AddValue(KEY4, outTime);
            info.AddValue(KEY5, totalMinutes);
            info.AddValue(KEY6, day);
           /* info.AddValue(KEY7, Price);*/
        }
        public string GetDay()
        {
            string i = date.ToString("dddd");
            return i;
        }
        public double CalculateTotalMinutes()
        {
            var OutTime = new TimeSpan(outTime.Hours, outTime.Minutes, 0);
            var InTime = new TimeSpan(inTime.Hours, inTime.Minutes, 0);
            return outTime.Subtract(inTime).TotalMinutes;
        }
    }
}
