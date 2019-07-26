using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankLib.Repository;

namespace MDIBankApp
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.usernameTextBox.Text;
            string password = this.passwordTextBox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("All fields are mandatory");
            }
            else
            {
                LoginRepo loginRepo = new LoginRepo();
                if (loginRepo.LoginUser(username, password) == true)
                {
                    BankApp.loggedUser = username;
                    


                    ////UserForm userForm = new UserForm();
                    ////userForm.Region = this.Region;
                    this.Hide();
                    
                    //userForm.MdiParent = Owner;
                    //userForm.Show();
                }
            }
        }
    }
}
