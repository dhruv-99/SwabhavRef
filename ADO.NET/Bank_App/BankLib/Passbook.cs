using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlClient;

namespace BankLib
{
  public class Passbook
    {
        private static readonly string filePath = "S:/Swabhhav techlabs/ADO.NET/Bank_App/PassBook.csv";
        public void DownloadPassbook()
        {
            object[] passBook = new object[10];
            using (SqlConnection connection = DatabaseConnection.get_instance())
            {
                connection.Open();
                var command = new SqlCommand("select * from bank_transaction", connection);
                var dataReader = command.ExecuteReader();

                StringBuilder sb = new StringBuilder();
                while (dataReader.Read())
                {
                    dataReader.GetValues(passBook);
                    sb.AppendLine(passBook[0] + "," + passBook[1] + "," + passBook[2]+","+passBook[3]);
                }
                File.WriteAllText(filePath, sb.ToString());
            }
        }
    }
}
