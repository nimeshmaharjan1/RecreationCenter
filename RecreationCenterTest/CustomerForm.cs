using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenterTest
{
    public partial class CustomerForm : Form
    {
        private BindingSource _customerBindingSource = new BindingSource();
        private CustomerDetails _customerDetailsRepo = new CustomerDetails();
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void goHomeBtn_Click(object sender, EventArgs e)
        {
            homeScreen homeForm = new homeScreen();
            homeForm.Show();
            this.Hide();
        }

        //OPENS ADD CUSTOMER FORM
        private void addCustomerBtn_Click(object sender, EventArgs e)
        {
            //NEW OBJECT OF AddCustomerForm
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.MaximizeBox = false;
            var result = addCustomerForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var newCustomer = addCustomerForm.Customer;
                newCustomer.customerId = _customerDetailsRepo.GenerateId();
                _customerBindingSource.Add(newCustomer);
                _customerDetailsRepo.SaveCustomers((List<Customer>)_customerBindingSource.DataSource);
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            _customerBindingSource.DataSource = new List<Customer>();
            // if set to true creates a new object if the list is empty
            _customerBindingSource.AllowNew = false;
            customerListGridView.DataSource = _customerBindingSource;

            //calls this method to get the vehicle list.
            retrieveCustomer_Click(sender, e);

            //making grid readonly
            customerListGridView.ReadOnly = true;
        }

        private void saveCustomer_Click(object sender, EventArgs e)
        {
            _customerDetailsRepo.SaveCustomers((List<Customer>)_customerBindingSource.DataSource);
        }

        private void retrieveCustomer_Click(object sender, EventArgs e)
        {
            //GET VISITOR DATA AND STORE IT IN DATASOURCE
            _customerBindingSource.DataSource = _customerDetailsRepo.GetCustomer();
            _customerBindingSource.AllowNew = false;
            //DISPLAY DATA IN THE GRID VIEW
            customerListGridView.DataSource = _customerBindingSource;
            //GRID VIEW READONLY
            customerListGridView.ReadOnly = true;
        }

        private void importCustomer_Click(object sender, EventArgs e)
        {
            //CREATING AN INSTANCE OF WINDOWS FILE OPEN DIALOG BOX
            var dialogBox = new OpenFileDialog();
            //SETTING FILTER FOR CSV FILES
            dialogBox.Filter = "CSV files|*.csv";

            //STORING THE OPENED DIALOG BOX INTO A VARIABLE
            var result = dialogBox.ShowDialog();

            //IF RESULTS CLICK ON OK
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //READ ALL THE LINES IN THE FILE
                var csvString = File.ReadAllText(dialogBox.FileName);
                //Step 2: Pass the csvString to ReadFromCSV method from _vehicleRepository class
                //Step 3: Save the value to the binding source. (Binding Source is used by our grid).
                _customerBindingSource.DataSource = _customerDetailsRepo.ReadFromCSV(csvString);
            }
        }

        private void exportCustomer_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            //FILE TO BE SAVED WITH .csv EXTENSION
            dialog.Filter = "CSV File|*.csv";
            dialog.AddExtension = true;

            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //DATA LIST TO BE EXPORTED IN CSV FORMAT
                _customerDetailsRepo.ExportToCSV((List<Customer>)_customerBindingSource.DataSource, dialog.FileName);
            }
        }
    }
}
