using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RecreationCenter
{
    [Serializable()]
    public class TicketPrice : ISerializable
    {
        public int SerialNo { get; set; }
        public string CustomerType { get; set; }
        public int OneHour { get; set; }
        public int TwoHour { get; set; }
        public int ThreeHour { get; set; }
        public int FourHour { get; set; }
        public int WholeDay { get; set; }

        //Creating key and value pairs for serialization
        public static string KEY = "SerialNo";
        public static string KEY1 = "CustomerType";
        public static string KEY2 = "OneHour";
        public static string KEY3 = "TwoHour";
        public static string KEY4 = "ThreeHour";
        public static string KEY5 = "FourHour";
        public static string KEY6 = "WholeDay";

        //Default Constructor with no parameters
        public TicketPrice() { }

        //CONSTRUCTOR OVERLOADING FOR DESERIALIZATION
        public TicketPrice(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties
            SerialNo = (int)serial.GetValue(KEY, typeof(int));
            CustomerType = (string)serial.GetValue(KEY1, typeof(string));
            OneHour = (int)serial.GetValue(KEY2, typeof(int));
            TwoHour = (int)serial.GetValue(KEY3, typeof(int));
            ThreeHour = (int)serial.GetValue(KEY4, typeof(int));
            FourHour = (int)serial.GetValue(KEY5, typeof(int));
            WholeDay = (int)serial.GetValue(KEY6, typeof(int));
        }
        //this method converts the properties to object data using Key and value pair as mentioned above
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // read the values with the same name. 
            info.AddValue(KEY, SerialNo);
            info.AddValue(KEY1, CustomerType);
            info.AddValue(KEY2, OneHour);
            info.AddValue(KEY3, TwoHour);
            info.AddValue(KEY4, ThreeHour);
            info.AddValue(KEY5, FourHour);
            info.AddValue(KEY6, WholeDay);

        }
    }
   
}
