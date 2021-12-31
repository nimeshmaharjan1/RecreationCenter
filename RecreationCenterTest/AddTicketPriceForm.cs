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
    public partial class AddTicketPriceForm : Form
    {
        public AddTicketPriceForm()
        {
            InitializeComponent();
        }
        public TicketPrice TicketPrice
        {
            get
            {
                var ticketPrice = new TicketPrice();
                ticketPrice.CustomerType = TicketRateTextBox.Text;
                ticketPrice.OneHour = int.Parse(OneHourTextBox.Text);
                ticketPrice.TwoHour = int.Parse(TwoHourTextBox.Text);
                ticketPrice.ThreeHour = int.Parse(ThreeHourTextBox.Text);
                ticketPrice.FourHour = int.Parse(FourHourTextBox.Text);
                ticketPrice.WholeDay = int.Parse(WholeDayTextBox.Text);
                return ticketPrice;
            }

        }

        private void AddTicketPriceForm_Load(object sender, EventArgs e)
        {

        }
    }
}
