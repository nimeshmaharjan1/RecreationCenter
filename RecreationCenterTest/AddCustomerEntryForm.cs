using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenterTest
{
    public partial class AddCustomerEntryForm : Form
    {
        private CustomerDetails _customerRepository = new CustomerDetails();
        // private VisitorEntryDetailRepository _entryDetailRepository = new VisitorEntryDetailRepository();
        private BindingSource _customerBindingSource = new BindingSource();
        public AddCustomerEntryForm()
        {
            InitializeComponent();
        }
        public CustomerEntry CustomerEntry
        {
            get
            {
                var entryDetail = new CustomerEntry();
                entryDetail.CustomerName = Convert.ToString(nameComboBox.SelectedValue);
                entryDetail.Date = entryDatePicker.Value.Date;
                entryDetail.Day = entryDatePicker.Value.DayOfWeek.ToString();
                entryDetail.InTime = inTimePicker.Value.TimeOfDay;
                entryDetail.OutTime = outTimePicker.Value.TimeOfDay;
                entryDetail.TotalMinutes = entryDetail.CalculateTotalMinutes();
                entryDetail.Day = entryDetail.GetDay();
                entryDetail.Price = int.Parse(priceTextBox.Text);
                entryDetail.CustomerType = customerTypeComboBox.Text.ToString();
                /*entryDetail.TotalRevenue = entryDetail.GetTotalRevenue();*/
                return entryDetail;
            }
        }
        private void AddCustomerEntryForm_Load(object sender, EventArgs e)
        {
            GetVisitorData(sender, e);
        }
        private void GetVisitorData(object sender, EventArgs e)
        {
            //to display in grid
            _customerBindingSource.DataSource = _customerRepository.GetCustomer();

            //if set to true creates a new object if the list is empty.
            _customerBindingSource.AllowNew = false;

            nameComboBox.DataSource = _customerBindingSource;
            nameComboBox.DisplayMember = "customerName";
            nameComboBox.ValueMember = "customerName";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void priceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void outTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var i = outTimePicker.Value.Hour;
            if ((i < 10) || (i > 18))
            {
                MessageBox.Show("Sorry, at that time the recreation center will be closed.");

                if (i < 10)
                {
                    this.outTimePicker.Value = DateTime.Parse("10:00:00");
                }
                else if (i > 18)
                {
                    this.outTimePicker.Value = DateTime.Parse("17:59:00");
                }
                else
                {
                    this.outTimePicker.Value = DateTime.Now;
                }
                return;
            }
        }

        private void inTimePicker_ValueChanged(object sender, EventArgs e)
        {
            var i = inTimePicker.Value.Hour;
            if ((i < 10) || (i > 18))
            {
                MessageBox.Show("Sorry, at that time the recreation center will be closed.");

                if (i < 10)
                {
                    this.inTimePicker.Value = DateTime.Parse("10:00:00");
                }
                else if (i > 18)
                {
                    this.inTimePicker.Value = DateTime.Parse("17:59:00");
                }
                else
                {
                    this.inTimePicker.Value = DateTime.Now;
                }
                return;
            }
        }

        private void price_Click(object sender, EventArgs e)
        {

        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
