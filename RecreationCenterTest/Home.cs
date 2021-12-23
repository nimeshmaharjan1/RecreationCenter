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

        private void addCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.Show();
            this.Hide();
        }

        private void customerDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCustomerEntryForm addCustomerEntryForm = new AddCustomerEntryForm();
            addCustomerEntryForm.Show();
            this.Hide();
        }
    }
}
