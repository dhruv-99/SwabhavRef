using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee ceo = new Employee(1, "Dhruv", "CEO", 50000);
            Employee headSales = new Employee(2, "Sanal", "Sales Head", 45000);
            Employee headMarketing = new Employee(3, "Akash", "Marketing Head", 60000);
            Employee accountant = new Employee(4, "Akhilesh", "Accountant", 50000);
            Employee fieldManager = new Employee(5, "Dipesh", "Field Manager", 45000);

            ceo.Add(headSales);
            ceo.Add(headMarketing);

            headSales.Add(accountant);
            headMarketing.Add(fieldManager);

            Console.WriteLine(ceo);
            foreach (Employee headEmployee in ceo.Subordinates)
            {
                Console.WriteLine(headEmployee);
                foreach (Employee employee in headEmployee.Subordinates)
                    Console.WriteLine(employee);
            }
        }
    }
}
