﻿using System;
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
        public int customerId { get; set; }
        public string customerName { get; set; }
        public int customerAge { get; set; }
        public string customerAddress { get; set; }
        public string customerContact { get; set; }

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
            customerId = (int)serial.GetValue(KEY, typeof(int));
            customerName = (string)serial.GetValue(KEY1, typeof(string));
            customerAge = (int)serial.GetValue(KEY2, typeof(int));
            customerAddress = (string)serial.GetValue(KEY3, typeof(string));
            customerContact = (string)serial.GetValue(KEY4, typeof(string));
        }

        
        //this method converts the properties to object data using Key and value pair as mentioned above
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            //You can use any custom name for your name-value pair. But make sure you
            // read the values with the same name. 
            info.AddValue(KEY, customerId);
            info.AddValue(KEY1, customerName);
            info.AddValue(KEY2, customerAge);
            info.AddValue(KEY3, customerAddress);
            info.AddValue(KEY4, customerContact);

        }

    }

}