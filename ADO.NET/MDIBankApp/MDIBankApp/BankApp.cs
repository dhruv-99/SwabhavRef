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
    public partial class BankApp : Form
    {
        public static string loggedUser;
        LoginForm login;
        public BankApp()
        {
            InitializeComponent();
            login = new LoginForm();
            login.MdiParent = this;
            login.Show();
            performTransactionToolStripMenuItem.Enabled = false;
            passbookToolStripMenuItem.Enabled = false;
            logOutToolStripMenuItem.Enabled = false;

            //if (!loggedUser.Equals(null))
            //{
            //    performTransactionToolStripMenuItem.Enabled = true;
            //    passbookToolStripMenuItem.Enabled = true;
            //    logOutToolStripMenuItem.Enabled = true;
            //}

        }

        private void registerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            login.Close();
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.MdiParent = this;
            registrationForm.Show();
        }

        private void performTransactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            
                TransactionForm transaction = new TransactionForm();
                transaction.MdiParent = this;
                transaction.Show();
            
        }

        private void passbookToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
                PassbookForm passbookForm = new PassbookForm();
                passbookForm.MdiParent = this;
            
        }
    }
}
