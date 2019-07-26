using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIBankApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            BankLib.Model.BankMaster bankMaster;
            InitializeComponent();
            BankLib.Repository.UserRepo userRepo = new BankLib.Repository.UserRepo();
            bankMaster = userRepo.GetUserDetails(BankApp.loggedUser);

            usernammeLabel.Text = bankMaster.Name;
            usernameLabel2.Text = bankMaster.Name;
            currentBalanceLabel.Text = Convert.ToString(bankMaster.Balance);
            
        }

        private void passbookButton_Click(object sender, EventArgs e)
        {
            PassbookForm passbookForm = new PassbookForm();
            passbookForm.Region = this.Region;
            this.Hide();
            passbookForm.Show();
        }

        private void transactionButton_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Region = this.Region;
            this.Hide();
            transactionForm.displayUsernameLabel.Text = usernammeLabel.Text ;
            transactionForm.Show();
        }
    }
}
