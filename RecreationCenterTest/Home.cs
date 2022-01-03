using RecreationCenter;
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
    public partial class homeScreen : Form
    {
        public homeScreen()
        {
            InitializeComponent();
        }

        private void AddCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.Show();
            this.Hide();
        }

        private void CustomerDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerEntryForm customerEntryForm = new CustomerEntryForm();
            customerEntryForm.Show();
            this.Hide();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void DailyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                DailyReport report = new DailyReport();
                report.Show();
        }

        private void ReportsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void WeeklyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
                WeeklyReportForm reportForm = new WeeklyReportForm();
                reportForm.Show();
        }

        private void GenerateChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
                Chart chart = new Chart();
                chart.Show();
           
        }

        private void AdminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanelForm adminPanelForm = new AdminPanelForm();
            adminPanelForm.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
