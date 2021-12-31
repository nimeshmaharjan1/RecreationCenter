using RecreationCenterTest;
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

namespace RecreationCenter
{
    public partial class AdminPanelForm : Form
    {
        private BindingSource _ticketPriceBindingSource = new BindingSource();
        private TicketPriceRepo _ticketPriceRepo = new TicketPriceRepo();
        public AdminPanelForm()
        {
            InitializeComponent();
        }

        private void AddTicketPriceBtn_Click(object sender, EventArgs e)
        {
            //NEW OBJECT OF AddTicketPriceForm
            AddTicketPriceForm addTicketPrice = new AddTicketPriceForm();
            addTicketPrice.MaximizeBox = false;
            var result = addTicketPrice.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                var newTicketPrice = addTicketPrice.TicketPrice;
                newTicketPrice.SerialNo = _ticketPriceRepo.GenerateSerialNo();
                _ticketPriceBindingSource.Add(newTicketPrice);
                _ticketPriceRepo.SaveTicketPrice((List<TicketPrice>)_ticketPriceBindingSource.DataSource);
            }

        }

        private void RetrievePrice_Click(object sender, EventArgs e)
        {
            //GET Ticket Price DATA AND STORE IT IN DATASOURCE
            _ticketPriceBindingSource.DataSource = _ticketPriceRepo.GetTicketPrices();
            _ticketPriceBindingSource.AllowNew = false;
            //DISPLAY DATA IN THE GRID VIEW
            ticketPriceListGridView.DataSource = _ticketPriceBindingSource;
            //GRID VIEW READONLY
            ticketPriceListGridView.ReadOnly = true;
        }

        private void AdminPanelForm_Load(object sender, EventArgs e)
        {
            _ticketPriceBindingSource.DataSource = new List<TicketPrice>();
            // if set to true creates a new object if the list is empty
            _ticketPriceBindingSource.AllowNew = false;
            ticketPriceListGridView.DataSource = _ticketPriceBindingSource;

            //calls this method to get the ticket Price list.
            RetrievePrice_Click(sender, e);

            //making grid readonly
            ticketPriceListGridView.ReadOnly = true;
        }

        private void SavePrice_Click(object sender, EventArgs e)
        {
            _ticketPriceRepo.SaveTicketPrice((List<TicketPrice>)_ticketPriceBindingSource.DataSource);
        }


        private void ImportTicketPrice_Click(object sender, EventArgs e)
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
                //Pass the csvString to ReadFromCSV method from Customer class
                //Save the value to the binding source. (Binding Source is used by the grid).
                _ticketPriceBindingSource.DataSource = _ticketPriceRepo.ReadFromCSV(csvString);
            }
        }

        private void exportTicketPrice_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            //FILE TO BE SAVED WITH .csv EXTENSION
            dialog.Filter = "CSV File|*.csv";
            dialog.AddExtension = true;

            var result = dialog.ShowDialog();

            if (result == System.Windows.Forms.DialogResult.OK)
            {
                //DATA LIST TO BE EXPORTED IN CSV FORMAT
                _ticketPriceRepo.ExportToCSV((List<TicketPrice>)_ticketPriceBindingSource.DataSource, dialog.FileName);
            }
        }

        private void goHomeBtn_Click(object sender, EventArgs e)
        {
            homeScreen homeForm = new homeScreen();
            homeForm.Show();
            this.Hide();
        }
    }
}
