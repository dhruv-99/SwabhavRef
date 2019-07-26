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
    public partial class TransactionForm : Form
    {
        
        public TransactionForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string name = this.displayNameLable.Text;
            string amount = this.transactionAmountTextBox.Text;
            string type = null;
            if (this.DepositRadioButton.Checked == true)
            {
                type = this.DepositRadioButton.Text;
            }
            if (this.WithdrawRadioButton.Checked == true)
            {
                type = this.WithdrawRadioButton.Text;
            }
            PerformTransactionRepo transactionRepo = new PerformTransactionRepo();
            if (transactionRepo.DoTransaction(name, amount, type) == true)
            {
                BankLib.Repository.UserRepo userRepo = new BankLib.Repository.UserRepo();
                BankLib.Model.BankMaster tMaster = userRepo.GetUserDetails(LoginForm.loggedUser);
                MessageBox.Show("Transaction successfull");
                UserForm userForm = new UserForm();
                userForm.currentBalanceLabel.Text =Convert.ToString(tMaster.Balance); 
                this.Region = userForm.Region;
                this.Hide();
                userForm.Show();
            }
        }
    }
}
