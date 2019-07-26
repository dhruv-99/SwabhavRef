using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankLib;

namespace BankApp
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            string name = this.nameTextBox.Text;
            string password = this.passwordTextBox.Text;
            string confirmPassword = this.confirmPassTextBox.Text;
            string deposit = this.initialDepoTextBox.Text;
            if (name == "" || password == "" || confirmPassword == "" || deposit == "")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else if (!password.Equals(confirmPassword))
            {
                MessageBox.Show("Passwords do not match");
            }
            else
            {
                RegistrationRepo newRegistration = new RegistrationRepo();
                if (newRegistration.RegisterUser(name, password, confirmPassword, deposit) == true)
                {
                    this.registerButton.Enabled = false;
                    LoginForm loginForm = new LoginForm();
                    loginForm.Region = this.Region;
                    this.Hide();
                    loginForm.Show();
                }
                else
                {
                    MessageBox.Show("Registration unsuccessfull");
                }
            }

        }
    }
}
