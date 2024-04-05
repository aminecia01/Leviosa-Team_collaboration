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
                // If login is successful, display a success message in lblMessage
                lblMessage.ForeColor = Color.Green; // Set text color to green for success
                lblMessage.Text = "Login successful!";

                // hide the login form and show the main application form
                // this.Hide();
                // MainForm mainForm = new MainForm();
                // mainForm.Show();
            }
            else
            {
                // If login fails, display an error message in lblMessage
                lblMessage.ForeColor = Color.Red; // Set text color to red for errors
                lblMessage.Text = "Login failed. Please check your username and password.";
            }
        }
    }
}
