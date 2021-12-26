using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenterTest
{
    class CustomerDetails
    {
        private List<Customer> _customerDetailsList = new List<Customer>();
        //LOCATION OF FILE TO SAVE STATE OBJECT
        private string filepath = Path.GetDirectoryName(Application.ExecutablePath);
        private string filePath;

        //SERIALIZATION TO CONVERT LIST INTO OBJECT DATA
        private void serializeCustomerDetails(List<Customer> customers)
        {
            try
            {

                //CREATE A NEW FILE OR OPEN THE FILE IF IT ALREADY EXISTS
                Stream file = File.Open(filePath + @"\customerDetails.dat", FileMode.Create);
                //CREATING AN OBJECT OF BINARY FORMATTER TO USE THE SERIALIZATION METHOD
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                //CONVERT LIST INTO .DAT FILE
                binaryFormatter.Serialize(file, customers);
                //WRITES BUFFERED DATA INTO THE FILE
                file.Flush();
                file.Close();
                MessageBox.Show("Customer Details have been saved.");
            }
            catch(Exception e)
            {
                MessageBox.Show("Not able to save data.");
            }
        }
        //DESERIALIZATION TO CONVERT OBJECT DATA INTO LIST
        private void DeserializeCustomerDetails()
        {
            try
            {
                if (File.Exists(filePath + @"\customerDetails.dat"))
                {
                    Stream file = File.Open(filePath + @"\customerDetails.dat", FileMode.Open);
                    if(file != null && file.Length > 0)
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        _customerDetailsList = (List<Customer>)binaryFormatter.Deserialize(file);
                        MessageBox.Show("Customer Details have been retrieved.");
                    }
                    file.Close();
                }
            
            }
            catch(Exception e)
            {
                MessageBox.Show("Not able to retrieve data.");
            }
        }

        //READ THE CSV FILE AND CONVERT IT TO C# OBJECT
        public List<Customer> ReadFromCSV(string csvString)
        {
            var customerList = new List<Customer>();
            try
            {
                //SKIPPING THE FIRST ROW AS IT CONTAINS THE PROPERTY TITLES
                var lines = csvString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
                foreach (var item in lines)
                {
                    var values = item.Split(',');
                    var customer = new Customer();
                    customer.customerId = Convert.ToInt32(values[0]);
                    customer.customerName = values[1];
                    customer.customerAge = Convert.ToInt32(values[2]);
                    customer.customerAddress = values[3];
                    customer.customerContact = values[4];


                    customerList.Add(customer);
                }
                _customerDetailsList = customerList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not able to import data at this moment. PLease try again.");
            }
            return customerList;

        }

        //EXPORTING TO CSV FILE
        public void ExportToCSV(List<Customer> customers, string filePath)
        {
            try
            {
                if (customers.Count > 0)
                {
                    var propList = customers[0].GetType().GetProperties().Select(prop => prop.Name).ToList();

                    //TEXTWRITER IS USED TO CREATE THE OUTPUT AND STREAMWRITER IS USED TO READ THE FILE LOCATION
                    using (TextWriter TW = new StreamWriter(filePath, append: true))
                    {
                        //writes header
                        foreach (var prop in propList)
                        {
                            TW.Write(prop.ToString() + ",");
                        }
                        TW.WriteLine();
                        //writes values
                        foreach (var val in customers)
                        {
                            foreach (PropertyInfo prop in val.GetType().GetProperties())
                            {
                                TW.Write(prop.GetValue(val, null).ToString() + ",");
                            }
                            TW.WriteLine();

                        }
                    }
                    MessageBox.Show("The records have been saved successfully.");
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, unable to save records.");
            }
        }

        //READS CUSTOMER DATA FROM THE OBJECT SOURCE AND RETURNS A LIST
        public List<Customer> GetCustomer()
        {
            //step 1: get data from the file.
            DeserializeCustomerDetails();
            //check if it is null or empty.
            if (_customerDetailsList != null && _customerDetailsList.Count > 0)
            {
                return _customerDetailsList;
            }
            else
            {
                _customerDetailsList = new List<Customer>();
                return _customerDetailsList;
            }

        }
        public int GenerateId()
        {
            int id = 0;

            //TO CHECK IF THE LIST IS EMPTY OR NULL
            if (_customerDetailsList != null && _customerDetailsList.Count > 0)
            {
                id = _customerDetailsList.Max(a => a.customerId);
            }

            return id + 1;
        }
        //ACCEPTS THE LIST OF CUSTOMERS AND SERIALIZES THE DATA TO SAVE AS AN OBJECT DATA..

        public void SaveCustomers(List<Customer> customers)
        {
            serializeCustomerDetails(customers);
        }
    }
}
