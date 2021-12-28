using RecreationCenterTest;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecreationCenter
{
    public partial class WeeklyReportForm : Form
    {
        private CustomerEntryDetails _entryDetailRepository = new CustomerEntryDetails();
        private List<CustomerEntry> _entryDetailList = new List<CustomerEntry>();
        public WeeklyReportForm()
        {
            InitializeComponent();
        }
        private void FillChart()
        {
            foreach (var entryDetail in _entryDetailList)
            {
                var a = entryDetail.Date.DayOfWeek.ToString();
                var b = entryDetail.TotalMinutes.ToString();
                var c = entryDetail.Count.ToString();
                var d = entryDetail.Price.ToString();
                /*var d = entryDetail.TotalRevenue.ToString();*/
                this.weeklyGridView.Rows.Add(a, c, d, b);
            }
        }

        private void WeeklyReportForm_Load(object sender, EventArgs e)
        {
            _entryDetailList = _entryDetailRepository.GetWeeksData();
            FillChart();
        }

        private void sortByBtn_Click(object sender, EventArgs e)
        {
            this.weeklyGridView.Sort(this.weeklyGridView.Columns["Column2"], ListSortDirection.Ascending);
        }

        private void weeklyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void sortByTotalRevenueBtn_Click(object sender, EventArgs e)
        {
            this.weeklyGridView.Sort(this.weeklyGridView.Columns["Column3"], ListSortDirection.Ascending);
        }
    }
}
