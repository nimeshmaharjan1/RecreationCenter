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
                visitChart.Series["Visitation"].Points.AddXY(visit.date.DayOfWeek.ToString(), visit.totalMinutes.ToString());
            }
            visitChart.Titles.Add("Total Visitation in Minutes");
        }

        private void visitChart_Click(object sender, EventArgs e)
        {

        }
    }
}
