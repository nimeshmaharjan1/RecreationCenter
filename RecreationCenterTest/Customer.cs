using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RecreationCenterTest
{
    [Serializable()]
    public class Customer : ISerializable
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int CustomerAge { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerContact { get; set; }

        //Creating key and value pairs for serialization
        public static string KEY = "customerId";
        public static string KEY1 = "customerName";
        public static string KEY2 = "customerAge";
        public static string KEY3 = "customerAddress";
        public static string KEY4 = "customerContact";

        public Customer() { }

        //CONSTRUCTOR OVERLOADING FOR DESERIALIZATION
        public Customer(SerializationInfo serial, StreamingContext context)
        {
            //Get the values from info and assign them to the appropriate properties
            CustomerId = (int)serial.GetValue(KEY, typeof(int));
            CustomerName = (string)serial.GetValue(KEY1, typeof(string));
            CustomerAge = (int)serial.GetValue(KEY2, typeof(int));
            CustomerAddress = (string)serial.GetValue(KEY3, typeof(string));
            CustomerContact = (string)serial.GetValue(KEY4, typeof(string));
        }

        
        //this method converts the properties to object data using Key and value pair as mentioned above
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            // read the values with the same name. 
            info.AddValue(KEY, CustomerId);
            info.AddValue(KEY1, CustomerName);
            info.AddValue(KEY2, CustomerAge);
            info.AddValue(KEY3, CustomerAddress);
            info.AddValue(KEY4, CustomerContact);

        }

    }

}
