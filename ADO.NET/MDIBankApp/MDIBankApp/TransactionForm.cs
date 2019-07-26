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
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void commitButton_Click(object sender, EventArgs e)
        {
            string name = this.displayUsernameLabel.Text;
            double amount = Convert.ToDouble(this.amountTextBox.Text);
            string type = null;
            if (this.depositRadioButton.Checked == true)
            {
                type = this.depositRadioButton.Text;
            }
            if (this.withdrawRadioButton.Checked == true)
            {
                type = this.withdrawRadioButton.Text;
            }
            PerformTransactionRepo transactionRepo = new PerformTransactionRepo();
            if (transactionRepo.DoTransaction(name, amount, type) == true)
            {
                BankLib.Repository.UserRepo userRepo = new BankLib.Repository.UserRepo();
                BankLib.Model.BankMaster tMaster = userRepo.GetUserDetails(BankApp.loggedUser);
                MessageBox.Show("Transaction successfull");
                UserForm userForm = new UserForm();
                userForm.currentBalanceLabel.Text = Convert.ToString(tMaster.Balance);
                this.Region = userForm.Region;
                this.Hide();
                userForm.Show();
            }
        }
    }
}
