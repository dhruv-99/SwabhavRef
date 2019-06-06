using System;
using System.Collections.Generic;
using System.Text;

namespace UserDefinedExceptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Dhruv");
            try
            {
                if (employee.Name == "Dhruv")
                    throw new DhruvException("Name dhruv is found");
                Console.WriteLine("Name of the employee is " + employee.Name);
            }
            catch (DhruvException dhruvexception)
            {
                Console.WriteLine(dhruvexception);
            }



        }
    }
}
