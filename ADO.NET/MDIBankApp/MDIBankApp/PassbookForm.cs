using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BankLib.Repository;
using System.IO;

namespace MDIBankApp
{
    public partial class PassbookForm : Form
    {
        PassbookRepo passbookRepo;
        public PassbookForm()
        {
            InitializeComponent();
            passbookRepo = new PassbookRepo();
            DataTable dataTable = new DataTable();

            dataTable.Columns.AddRange(new DataColumn[4]{
             new DataColumn("Name",typeof(string)),new DataColumn("Amount",typeof(double)),
             new DataColumn("Type",typeof(char)),new DataColumn("Date", typeof(DateTime))});
            foreach (BankLib.Model.BankTransaction transaction in passbookRepo.DownloadPassbook(BankApp.loggedUser))
            {
                DataRow row = dataTable.NewRow();
                row["Name"] = transaction.Name;
                row["Amount"] = transaction.Amount;
                row["Type"] = transaction.Type;
                row["Date"] = transaction.Date;
                dataTable.Rows.Add(row);

            }
            this.passbookGridView.DataSource = dataTable;
        }

        private void downloadButton_Click(object sender, EventArgs e)
        {
            passbookRepo = new PassbookRepo();
            StringBuilder builder = new StringBuilder();
            foreach (BankLib.Model.BankTransaction transaction in passbookRepo.DownloadPassbook(BankApp.loggedUser))
            {
                builder.AppendLine(transaction.Name + "," + transaction.Amount + "," + transaction.Type + "," + transaction.Date);
            }
            File.WriteAllText(PassbookRepo.PATH, builder.ToString());
            MessageBox.Show("Your file has been downloaded sccessfully");
            UserForm userForm = new UserForm();
            userForm.Region = this.Region;
            this.Hide();
            userForm.Show();
        }
    }
}
