using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace RecreationCenterTest
{
    class CustomerEntryDetails
    {
        private List<CustomerEntry> _customerEntryDetailsList = new List<CustomerEntry>();
        private string filePath = Path.GetDirectoryName(Application.ExecutablePath);

        private void SerializeCustomerEntryData(List<CustomerEntry> entryDetails)
        {
            try
            {
                Stream str = File.Open(filePath + @"\customerEntryDetails.dat", FileMode.Create);
                BinaryFormatter bF = new BinaryFormatter();
                bF.Serialize(str, entryDetails);
                str.Flush();
                str.Close();
                MessageBox.Show("Customer entry details have been saved.");
            }
            catch(Exception e)
            {
                MessageBox.Show("Sorry, not able to save data.");
            }
        }
        private void DeserializeCustomerEntryData()
        {
            try
            {
                //CHECK IF FILE EXISTS
                if (File.Exists(filePath + @"\customerEntryDetails.dat"))
                {
                    //OPEN FILE
                    Stream stream = File.Open(filePath + @"\customerEntryDetails.dat", FileMode.Open);

                    //CHECK IF THE FILE IS EMPTY OR NULL
                    if (stream != null && stream.Length > 0)
                    {
                        //CREATING AN OBJECT OF BINARY FORMATTER BECAUSE IT HAS A METHOD OF CONVERTING .DAT FILE INTO C# OBJECTS
                        BinaryFormatter binaryFormatter = new BinaryFormatter();

                        //CONVERTING INTO STATE OBJECTS THROUGH DESERIALIZE
                        _customerEntryDetailsList = (List<CustomerEntry>)binaryFormatter.Deserialize(stream);

                        MessageBox.Show("Customer Entry details have been retrived");
                    }
                    stream.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, not able to retrieve data.");
            }
        }
        public void SaveEntrydetails(List<CustomerEntry> entryDetails)
        {
            SerializeCustomerEntryData(entryDetails);
        }
        public List<CustomerEntry> ReadFromCSV(string csvString)
        {
            var entryCustomers = new List<CustomerEntry>();
            try
            {
                var lines = csvString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
                foreach (var item in lines)
                {
                    var values = item.Split(',');
                    var customerEntry = new CustomerEntry();
                    customerEntry.CustomerId = Convert.ToInt32(values[0]);
                    customerEntry.CustomerName = values[1];
                    customerEntry.Date = Convert.ToDateTime(values[2]);
                    customerEntry.InTime = Convert.ToDateTime(values[3]).TimeOfDay;
                    customerEntry.OutTime = Convert.ToDateTime(values[4]).TimeOfDay;
                    customerEntry.Price = Convert.ToInt32(values[5]);
                    customerEntry.CustomerType = (values[6]);

                    entryCustomers.Add(customerEntry);
                }
                _customerEntryDetailsList = entryCustomers;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, not able to import data.");
            }
            return entryCustomers;

        }
        public void ExportToCSV(List<CustomerEntry> customers, string filePath)
        {
            try
            {
                if (customers.Count > 0)
                {
                    var propList = customers[0].GetType().GetProperties().Select(prop => prop.Name).ToList();

                    //TextWriter is used to create outputand streamWriter is used to read file location

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
                    MessageBox.Show("Customer entry details have been exported and saved successfully.");
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to export in the given moment. Please try again.");
            }

        }
        public List<CustomerEntry> GetEntryDetails()
        {
            DeserializeCustomerEntryData();

            if (_customerEntryDetailsList != null && _customerEntryDetailsList.Count > 0)
            {
                return _customerEntryDetailsList;
            }
            else
            {
                _customerEntryDetailsList = new List<CustomerEntry>();
                return _customerEntryDetailsList;
            }

        }
       /* public List<CustomerEntry> GetTotalRevenue()
        {
            DeserializeCustomerEntryData();

            if (_customerEntryDetailsList != null && _customerEntryDetailsList.Count > 0)
            {
                return _customerEntryDetailsList;
            }
            else
            {
                _customerEntryDetailsList = new List<CustomerEntry>();
                return _customerEntryDetailsList;
            }

        }*/
        public int GeneratesId()
        {
            int id = 0;
            if (_customerEntryDetailsList != null && _customerEntryDetailsList.Count > 0)
            {
                id = _customerEntryDetailsList.Max(a => a.CustomerId);
            }

            return id + 1;
        }

        //BUBBLE SORTING TO SORT THE LIST BY TOTAL MINUTES
        public List<CustomerEntry> BubbleSortUsingTotalMinutes()
        {
            for (int i = 0; i < _customerEntryDetailsList.Count; i++)
            {
                for (int j = 0; j < _customerEntryDetailsList.Count - 1; j++)
                {
                    var val1 = Convert.ToInt32(_customerEntryDetailsList[j].TotalMinutes);
                    var val2 = Convert.ToInt32(_customerEntryDetailsList[j + 1].TotalMinutes);
                    if (val1 > val2)
                    {
                        var temp = _customerEntryDetailsList[j + 1];
                        _customerEntryDetailsList[j + 1] = _customerEntryDetailsList[j];
                        _customerEntryDetailsList[j] = temp;
                    }
                }
            }
            return _customerEntryDetailsList;
        }
        public List<CustomerEntry> GetWeeksData()
        {
            DeserializeCustomerEntryData();
            if (_customerEntryDetailsList != null && _customerEntryDetailsList.Count > 0)
            {
                //SET MONDAY AS THE STARTING DAY OF THE WEEK
                var startOfWeek = DateTime.Now.AddDays(((int)DateTime.Now.DayOfWeek * -1) + 1);
                //SET DEFAULT TIME AS 10:00:00
                startOfWeek = new DateTime(startOfWeek.Year, startOfWeek.Month, startOfWeek.Day, 00, 0, 0);

                //SET MONDAY AS THE ENDING DAY OF THE WEEK AS THE RECREATION CENTER IS OPEN THE WHOLE WEEK
                var endOfWeek = startOfWeek.AddDays(7);
                //SET END DEFAULT TIME AS 18:00:00
                endOfWeek = new DateTime(endOfWeek.Year, endOfWeek.Month, endOfWeek.Day, 18, 0, 0);

                var weeklyData = (from entryDetail in _customerEntryDetailsList
                                  where entryDetail.Date >= startOfWeek
                                  && entryDetail.Date <= endOfWeek
                                  //GROUPS DATA BY DATE
                                  group entryDetail by entryDetail.Date into grp 
                                  select new CustomerEntry
                                  {
                                      //GET MAXIMUM VALUE
                                      Date = grp.Max(a => a.Date),
                                      Count = grp.Count(),
                                      /*TotalRevenue = grp.Sum(a => a.TotalRevenue),*/
                                      //SUM OF TOTAL MINUTES OF THE DAY
                                      Price = grp.Sum(a => a.Price),
                                      TotalMinutes = grp.Sum(a => a.TotalMinutes)
                                      //ORDER THE DATA IN DESCENDING ORDER AND RETURN A LIST
                                  }).OrderByDescending(a => a.Count).ToList(); 
                return weeklyData;
            }
            else
            {
                _customerEntryDetailsList = new List<CustomerEntry>();
                return _customerEntryDetailsList;
            }
        }
        public List<CustomerEntry> GetReportData()
        {
            DeserializeCustomerEntryData();
            if (_customerEntryDetailsList != null && _customerEntryDetailsList.Count > 0)
            {
                var currentDate = DateTime.Now;
                currentDate = new DateTime(currentDate.Year, currentDate.Month, currentDate.Day, 00, 0, 0);


                var dailyData = (from _entry in _customerEntryDetailsList
                                 where _entry.Date == currentDate
                                 group _entry by _entry.Date into grp 
                                 select new CustomerEntry
                                 {
                                     Date = grp.Max(a => a.Date),
                                     Count = grp.Count(),
                                     Price = grp.Sum(a => a.Price),
                                     TotalMinutes = grp.Sum(a => a.TotalMinutes)
                                 }).OrderByDescending(a => a.Count).ToList();
                return dailyData;
            }
            else
            {
                _customerEntryDetailsList = new List<CustomerEntry>();
                return _customerEntryDetailsList;
            }
        }
    }
}
