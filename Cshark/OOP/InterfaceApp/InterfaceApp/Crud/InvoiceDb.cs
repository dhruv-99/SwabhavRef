using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class InvoiceDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Invoice created");
        }
        public void Read()
        {
            Console.WriteLine("Invoice Data read");
        }
        public void Update()
        {
            Console.WriteLine("Invoice update");
        }
        public void Delete()
        {
            Console.WriteLine("Invoice Deleted");
        }
    }
}
