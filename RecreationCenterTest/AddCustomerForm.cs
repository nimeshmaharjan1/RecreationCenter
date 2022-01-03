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
    public partial class AddCustomerForm : Form
    {
        public AddCustomerForm()
        {
            InitializeComponent();
        }

        public Customer Customer
        {
            get
            {
                var customer = new Customer();
                customer.CustomerName = customerNameTextBox.Text;
                customer.CustomerAge = int.Parse(customerAgeTextBox.Text);
                customer.CustomerAddress = customerAddressTextBox.Text;
                customer.CustomerContact = customerContactTextBox.Text;
                return customer;
            }

        }

        private void AddCustomerForm_Load(object sender, EventArgs e)
        {

        }

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
/*            if(customerNameTextBox.Text == "" ||customerNameTextBox.Text == null)
            {
                MessageBox.Show("Customer Name cannot be blank", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }*/
        }
    }
}
