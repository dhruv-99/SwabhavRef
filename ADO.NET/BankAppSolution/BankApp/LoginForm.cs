using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankLib.Repository;
using BankLib.Model;

namespace BankApp
{
    public partial class LoginForm : Form
    {
        public static string loggedUser;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registration = new RegistrationForm();
            registration.Region = this.Region;
            registration.Show();
            this.Hide();

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            string username = this.usernameTextBox.Text;
            string password = this.loginPassTextBox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else
            {
                LoginRepo loginRepo = new LoginRepo();
                if (loginRepo.LoginUser(username, password) == true)
                {
                    loggedUser = username;
                    UserForm userForm = new UserForm();
                    userForm.Region = this.Region;
                    this.Hide();
                    userForm.Show();
                }
            }

        }
    }
}
