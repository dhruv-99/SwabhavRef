using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using BankLib.Model;

namespace BankLib
{
    public class PassbookRepo
    {
        private int _noOfColumns;
        public static readonly string PATH = "S:/Swabhhav techlabs/Passbook.csv";
        public List<BankTransaction> DownloadPassbook(string name)
        {
            List<BankTransaction> passbook = new List<BankTransaction>();
            BankTransaction transaction;
            using (SqlConnection connection = DBConnection.GetConnection())
            {
                try
                {
                    connection.Open();
                    var command = new SqlCommand
                        ("select * from bank_transaction where name = '"
                        + name + "'", connection);
                    var reader = command.ExecuteReader();
                    _noOfColumns = reader.FieldCount;
                    while (reader.Read())
                    {
                        transaction = new BankTransaction
                            (Convert.ToString(reader.GetValue(0)), Convert.ToDouble
                            (reader.GetValue(1)), Convert.ToChar(reader.GetValue(2))
                            , Convert.ToDateTime(reader.GetValue(3)));

                        passbook.Add(transaction);
                    }
                }
                catch (Exception)
                {

                }
                return passbook;
            }
        }
        public int Columns
        {
            get
            {
                return _noOfColumns;
            }
        }
    }
}
