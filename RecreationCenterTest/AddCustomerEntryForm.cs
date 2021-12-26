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
                entryDetail.customerName = Convert.ToString(nameComboBox.SelectedValue);
                entryDetail.date = entryDatePicker.Value.Date;
                entryDetail.day = entryDatePicker.Value.DayOfWeek.ToString();
                entryDetail.inTime = inTimePicker.Value.TimeOfDay;
                entryDetail.outTime = outTimePicker.Value.TimeOfDay;
                entryDetail.totalMinutes = entryDetail.CalculateTotalMinutes();
                entryDetail.day = entryDetail.GetDay();
                entryDetail.price = priceTextBox.Text;
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
    }
}
