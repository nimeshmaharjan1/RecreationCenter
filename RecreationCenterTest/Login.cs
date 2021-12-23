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
            string myUsername = "admin";
            string myPassword = "admin";
            //getting the value from the textbox where user types
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            //check if the username and password are correct
            if (username == myUsername && password == myPassword)//if matches then login
            {
                MessageBox.Show("Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
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

            homeScreen homeForm = new homeScreen();
            homeForm.Show();
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
