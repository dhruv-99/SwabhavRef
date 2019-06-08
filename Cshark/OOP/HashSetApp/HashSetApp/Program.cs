using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashSetApp
{
    class Program
    {
        static void Main(string[] args)
        {
            EmployeeName empName = new EmployeeName();
            do
            {
                Console.WriteLine("Press 1 to Add :");
                Console.WriteLine("Press 2 to Search :");
                Console.WriteLine("Press 3 to Delete :");
                Console.WriteLine("Press 4 to Display :");
                Console.WriteLine("Press 0 to exit :");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    empName.Add();
                }
                if(choice == 2)
                {
                    empName.Search();
                }
                if(choice == 3)
                {
                    empName.Delete();
                }
                if(choice == 0)
                {
                    break;
                }
                if(choice == 4)
                {
                    display(empName);
                }
               
            } while (true);
            
        }
        public static void display(EmployeeName empName)
        {
            foreach(string name in empName.employeeName)
            {
                Console.WriteLine(name);
            }
        }
    }
}
