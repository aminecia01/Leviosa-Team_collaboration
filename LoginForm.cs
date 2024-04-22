using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leviosa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string mockUsername = "admin";
            string mockPassword = "password";

            if (txtUsername.Text == mockUsername && txtPassword.Text == mockPassword)
            {
                // If login is successful, hide the login form
                this.Hide();

                // Create and show the main form
                MainForm mainForm = new MainForm();
                mainForm.Closed += (s, args) => this.Close(); // Ensure the application closes when the MainForm is closed
                mainForm.Show();
            }
            else
            {
                // If login fails, display an error message
                MessageBox.Show("Login failed. Please check your username and password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

