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
    public partial class CustomerForm : Form
    {
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

        private void addCustomerBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
