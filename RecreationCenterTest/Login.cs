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
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            //username and password of the user
            string adminUsername = "admin";
            string adminPw = "admin";
            string employeeUsername = "employee";
            string employeePw = "employee";
            //getting the value from the textbox where user types
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            //check if the username and password are correct for admin
            if (username == adminUsername && password == adminPw)//if matches then login
            {
                MessageBox.Show("Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                AdminPanelForm adminPanel = new AdminPanelForm();
                adminPanel.Show();
            }
            //check if the username and password are correct for admin
            else if (username == employeeUsername && password == employeePw)
            {
                MessageBox.Show("Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                homeScreen homeForm = new homeScreen();
                homeForm.Show();
            }
            //if one or more field is left empty
            else if (username == "" || password == "")
            {
                MessageBox.Show("One or more field empty! Please enter your credentails!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else //if doesnt match then show error message
            {
                MessageBox.Show("Invalid Credentials! Please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            DialogResult Exit;
            Exit = MessageBox.Show("Are you sure want to Exit? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (Exit == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
                return;
        }
    }
}
