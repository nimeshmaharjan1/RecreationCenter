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
    public partial class DailyReport : Form
    {
        private CustomerEntryDetails _entryDetailRepository = new CustomerEntryDetails();
        private List<CustomerEntry> _entryDetailList = new List<CustomerEntry>();
        public DailyReport()
        {
            InitializeComponent();
        }

        private void DailyReport_Load(object sender, EventArgs e)
        {
            _entryDetailList = _entryDetailRepository.GetReportData();
            FillChart();
        }
        private void FillChart()
        {
            foreach (var entryDetail in _entryDetailList)
            {
                var a = entryDetail.date.DayOfWeek.ToString();
                var b = entryDetail.totalMinutes.ToString();
                var c = entryDetail.Count.ToString();
                this.dailyGridView.Rows.Add(a, c, b);
            }
        }

        private void dailyGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
