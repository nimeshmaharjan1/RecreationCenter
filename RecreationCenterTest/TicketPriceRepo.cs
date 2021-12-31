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

namespace RecreationCenter
{
    class TicketPriceRepo
    {
        //CREATING A LIST OF TICKET PRICE CLASS
        private List<TicketPrice> _TicketPriceList = new List<TicketPrice>();
        //LOCATION OF FILE TO SAVE STATE OBJECT
        private string filepath = Path.GetDirectoryName(Application.ExecutablePath);
        private string filePath;

        //SERIALIZATION TO CONVERT LIST INTO OBJECT DATA
        private void SerializeTicketPrice(List<TicketPrice> ticketPrice)
        {
            try
            {

                //CREATE A NEW FILE OR OPEN THE FILE IF IT ALREADY EXISTS
                Stream file = File.Open(filePath + @"\ticketPrice.dat", FileMode.Create);
                //CREATING AN OBJECT OF BINARY FORMATTER TO USE THE SERIALIZATION METHOD
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                //CONVERT LIST INTO .DAT FILE
                binaryFormatter.Serialize(file, ticketPrice);
                //WRITES BUFFERED DATA INTO THE FILE
                file.Flush();
                file.Close();
                MessageBox.Show("The ticket prices have been saved.");
            }
            catch (Exception e)
            {
                MessageBox.Show("Not able to save data.");
            }
        }
        //DESERIALIZATION TO CONVERT OBJECT DATA INTO LIST
        private void DeserializeTicketPrice()
        {
            try
            {
                if (File.Exists(filePath + @"\ticketPrice.dat"))
                {
                    Stream file = File.Open(filePath + @"\ticketPrice.dat", FileMode.Open);
                    if (file != null && file.Length > 0)
                    {
                        BinaryFormatter binaryFormatter = new BinaryFormatter();
                        _TicketPriceList = (List<TicketPrice>)binaryFormatter.Deserialize(file);
                        MessageBox.Show("Ticket Prices have been retrieved.");
                    }
                    file.Close();
                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Not able to retrieve data.");
            }
        }
        //READ THE CSV FILE AND CONVERT IT TO C# OBJECT
        public List<TicketPrice> ReadFromCSV(string csvString)
        {
            var ticketPriceList = new List<TicketPrice>();
            try
            {
                //SKIPPING THE FIRST ROW AS IT CONTAINS THE PROPERTY TITLES
                var lines = csvString.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries).Skip(1);
                foreach (var item in lines)
                {
                    var values = item.Split(',');
                    var ticketPrice = new TicketPrice();
                    ticketPrice.SerialNo = Convert.ToInt32(values[0]);
                    ticketPrice.CustomerType = values[1];
                    ticketPrice.OneHour = Convert.ToInt32(values[2]);
                    ticketPrice.TwoHour = Convert.ToInt32(values[3]);
                    ticketPrice.ThreeHour = Convert.ToInt32(values[4]);
                    ticketPrice.FourHour = Convert.ToInt32(values[5]);
                    ticketPrice.WholeDay = Convert.ToInt32(values[6]);


                    ticketPriceList.Add(ticketPrice);
                }
                _TicketPriceList = ticketPriceList;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Not able to import data at this moment. PLease try again.");
            }
            return ticketPriceList;

        }
        //EXPORTING TO CSV FILE
        public void ExportToCSV(List<TicketPrice> ticketPrice, string filePath)
        {
            try
            {
                if (ticketPrice.Count > 0)
                {
                    var propList = ticketPrice[0].GetType().GetProperties().Select(prop => prop.Name).ToList();

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
                        foreach (var val in ticketPrice)
                        {
                            foreach (PropertyInfo prop in val.GetType().GetProperties())
                            {
                                TW.Write(prop.GetValue(val, null).ToString() + ",");
                            }
                            TW.WriteLine();

                        }
                    }
                    MessageBox.Show("The ticket prices have been saved successfully.");
                    Process.Start(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sorry, unable to save in the given moment.");
            }
        }
        //READS CUSTOMER DATA FROM THE OBJECT SOURCE AND RETURNS A LIST
        public List<TicketPrice> GetTicketPrices()
        {
            //step 1: get data from the file.
            DeserializeTicketPrice();
            //check if it is null or empty.
            if (_TicketPriceList != null && _TicketPriceList.Count > 0)
            {
                return _TicketPriceList;
            }
            else
            {
                _TicketPriceList = new List<TicketPrice>();
                return _TicketPriceList;
            }

        }
        public int GenerateSerialNo()
        {
            int serialNo = 0;

            //TO CHECK IF THE LIST IS EMPTY OR NULL
            if (_TicketPriceList != null && _TicketPriceList.Count > 0)
            {
                serialNo = _TicketPriceList.Max(a => a.SerialNo);
            }

            return serialNo + 1;
        }
        //ACCEPTS THE LIST OF TICKET PRICE AND SERIALIZES THE DATA TO SAVE AS AN OBJECT DATA.

        public void SaveTicketPrice(List<TicketPrice> ticketPrice)
        {
            SerializeTicketPrice(ticketPrice);
        }
    }
}
