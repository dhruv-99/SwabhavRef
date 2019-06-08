using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class CustomerDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Customer created");
        }
        public void Read()
        {
            Console.WriteLine("Customer Data read");
        }
        public void Update()
        {
            Console.WriteLine("Customer update");
        }
        public void Delete()
        {
            Console.WriteLine("Customer Deleted");
        }
    }
}