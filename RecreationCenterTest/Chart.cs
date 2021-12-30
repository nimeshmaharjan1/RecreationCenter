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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }
        private CustomerEntryDetails _customerEntryDetails = new CustomerEntryDetails();
        private List<CustomerEntry> _customerEntryList = new List<CustomerEntry>();

        private void Chart_Load(object sender, EventArgs e)
        {
            LoadVisit();
            FillChart();
        }
        private void LoadVisit()
        {
            _customerEntryList = _customerEntryDetails.GetWeeksData();
        }
        private void FillChart()
        {
            foreach (var visit in _customerEntryList)
            {
                EarningsChart.Series["Total Revenue"].Points.AddXY(visit.Date.DayOfWeek.ToString(), visit.Price.ToString());
                VisitorsChart.Series["Visitors"].Points.AddXY(visit.Date.DayOfWeek.ToString(), visit.Count.ToString());
            }
            EarningsChart.Titles.Add("Total Earnings");
            VisitorsChart.Titles.Add("Total Number of Visitors");
        }

        private void visitChart_Click(object sender, EventArgs e)
        {

        }

        private void VisitorsChart_Click(object sender, EventArgs e)
        {

        }
    }
}
