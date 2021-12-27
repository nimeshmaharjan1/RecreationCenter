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
        public WeeklyReportForm()
        {
            InitializeComponent();
        }
        private CustomerEntryDetails _visitRepository = new CustomerEntryDetails();
        private List<CustomerEntry> _visitList = new List<CustomerEntry>();
        private void FillChart()
        {
            foreach (var entryDetail in _visitList)
            {
                var a = entryDetail.date.DayOfWeek.ToString();
                var b = entryDetail.Count.ToString();
                var c = entryDetail.totalMinutes.ToString();
                this.weeklyGridView.Rows.Add(a, b, c);
            }
        }

        private void WeeklyReportForm_Load(object sender, EventArgs e)
        {
            _visitList = _visitRepository.GetWeeksData();
            FillChart();
        }

        private void sortByBtn_Click(object sender, EventArgs e)
        {
            this.weeklyGridView.Sort(this.weeklyGridView.Columns["Column2"], ListSortDirection.Ascending);
        }

        private void weeklyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
