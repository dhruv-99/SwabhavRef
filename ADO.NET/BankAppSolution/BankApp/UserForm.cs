using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankApp
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            BankLib.Model.BankMaster bankMaster;
            InitializeComponent();
            BankLib.Repository.UserRepo userRepo = new BankLib.Repository.UserRepo();
            bankMaster = userRepo.GetUserDetails(LoginForm.loggedUser);
            
            usernameLabel.Text = bankMaster.Name;
            usernameLabel2.Text = bankMaster.Name;
            currentBalanceLabel.Text =Convert.ToString(bankMaster.Balance);
        }

        private void PassbookButton_Click(object sender, EventArgs e)
        {
            PassbookForm passbookForm = new PassbookForm();
            passbookForm.Region = this.Region;
            this.Hide();
            passbookForm.Show();
        }

        private void DoTransactionButton_Click(object sender, EventArgs e)
        {
            TransactionForm transactionForm = new TransactionForm();
            transactionForm.Region = this.Region;
            this.Hide();
            transactionForm.displayNameLable = usernameLabel;
            transactionForm.Show();

        }
    }
}
