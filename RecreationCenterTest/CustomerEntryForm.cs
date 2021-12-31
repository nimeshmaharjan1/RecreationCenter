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
using RecreationCenter;

namespace RecreationCenterTest
{
    public partial class CustomerEntryForm : Form
    {
        private BindingSource _entryDetailBindingSource = new BindingSource();
        private BindingSource _ticketPriceBindingSource = new BindingSource();
        private CustomerEntryDetails _entryDetailRepository = new CustomerEntryDetails();
        private TicketPriceRepo _ticketPriceRepo = new TicketPriceRepo();
        public CustomerEntryForm()
        {
            InitializeComponent();
        }

        private void goHomeBtn_Click(object sender, EventArgs e)
        {
            homeScreen homeForm = new homeScreen();
            homeForm.Show();
            this.Hide();
        }

        private void EntryCustomer_Click(object sender, EventArgs e)
        {
            AddCustomerEntryForm addCustomerEntryForm = new AddCustomerEntryForm();
            addCustomerEntryForm.MaximizeBox = false;
            var result = addCustomerEntryForm.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                //save logic
                var newEntryDetail = addCustomerEntryForm.CustomerEntry;
                _entryDetailBindingSource.Add(newEntryDetail);

                //generate unique id and store.
                newEntryDetail.CustomerId = _entryDetailRepository.GeneratesId();

                //save to the object state file.
                _entryDetailRepository.SaveEntrydetails((List<CustomerEntry>)_entryDetailBindingSource.DataSource);


            }
        }

        private void SaveCustomerEntryBtn_Click(object sender, EventArgs e)
        {
            _entryDetailRepository.SaveEntrydetails((List<CustomerEntry>)_entryDetailBindingSource.DataSource);
        }

        private void RetrieveCustomerEntryBtn_Click(object sender, EventArgs e)
        {
            //GET THE CUSTOMER LIST
            _entryDetailBindingSource.DataSource = _entryDetailRepository.GetEntryDetails();

            //if set to true creates a new object if the list is empty.
            _entryDetailBindingSource.AllowNew = false;

            //display data in the binding source in the grid.
            //assign the list to the grid.
            customerEntryFormGridView.DataSource = _entryDetailBindingSource;
            customerEntryFormGridView.ReadOnly = true;
        }

        private void CustomerEntryForm_Load(object sender, EventArgs e)
        {
            RetrieveCustomerEntryBtn_Click(sender, e);
        }

        private void ExportCustomerEntryBtn_Click(object sender, EventArgs e)
        {
            //step 1: create an instance of windows default save dialog box.
            var dialog = new SaveFileDialog();
            //step 2: set filter so that the file can be saved with extenstion .csv.
            dialog.Filter = "CSV File|*.csv";
            dialog.AddExtension = true;
            //step 3: open the save dialog box
            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //export filename and our data list to the ExportToCSV class.
                _entryDetailRepository.ExportToCSV((List<CustomerEntry>)_entryDetailBindingSource.DataSource, dialog.FileName);
            }
        }

        private void ImportCustomerEntryBtn_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "CSV files|*.csv";

            //step 3: open the dialog box
            var result = dialog.ShowDialog();

            //check if  user has clicked OK.
            if (result == System.Windows.Forms.DialogResult.OK)
            {

                var csvString = File.ReadAllText(dialog.FileName);

                _entryDetailBindingSource.DataSource = _entryDetailRepository.ReadFromCSV(csvString);
            }
        }

        private void SortByBtn_Click(object sender, EventArgs e)
        {
            _entryDetailBindingSource.DataSource = _entryDetailRepository.BubbleSortUsingTotalMinutes();
            //refresh the grid to view the output.
            customerEntryFormGridView.Refresh();
        }

        private void CustomerEntryFormGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplayPriceRateBtn_Click(object sender, EventArgs e)
        {
            //GET THE Price Rate LIST
            _ticketPriceBindingSource.DataSource = _ticketPriceRepo.GetTicketPrices();

            //if set to true creates a new object if the list is empty.
            _ticketPriceBindingSource.AllowNew = false;

            //display data in the binding source in the grid.
            //assign the list to the grid.
            priceRateGridView.DataSource = _ticketPriceBindingSource;
            priceRateGridView.ReadOnly = true;
        }
    }
}
