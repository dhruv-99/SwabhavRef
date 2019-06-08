using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HashSetApp
{
   public class EmployeeName
    {
        public HashSet<string> employeeName;

        public EmployeeName()
        {
            employeeName = new HashSet<string>();
        }
        public void Add()
        {
            employeeName.Add("Sanal");
            employeeName.Add("Akash");
            employeeName.Add("Dhruv");
            employeeName.Add("Dipesh");
        }
        public void Search()
        {
           if(employeeName.Contains("Dipesh"))
            {
                Console.WriteLine("Name found");
            }
        } 
        public void Delete()
        {
            employeeName.Remove("Dhruv");
        }
    }
   
}
