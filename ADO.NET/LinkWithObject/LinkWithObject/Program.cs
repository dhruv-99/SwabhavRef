using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinkWithObject
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student() { FirstName = "Sanal", LastName = "Dhamanse", Cgpi = 7.5, Location = "Raigad" };
            var student2 = new Student() { FirstName = "Akash", LastName = "Jaiswal", Cgpi = 8.1, Location = "Prabhadevi" };
            var student3 = new Student() { FirstName = "Dhruv", LastName = "Ballikar", Cgpi = 7.9, Location = "Mumbai" };
            var student4 = new Student() { FirstName = "Priyank", LastName = "Shah", Cgpi = 5.9, Location = "Mumbai" };

            IEnumerable<Student> studentsDetails = new List<Student>() { student1, student2, student3, student4 };
            
            

            IEnumerable<Student> studentInMumbai =
                studentsDetails
                    .Where((stud) => stud.Location.Equals("Mumbai"));

            foreach (Student student in studentInMumbai)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.Cgpi + " " +
                                  student.Location);
            }
            var studentsLocatioAndName =
                studentsDetails
                    .Where((stud) => stud.Location.Equals("Mumbai"))
                    .Select((s) => new { s.Location, s.FirstName });

            
            foreach (var LocationName in studentsLocatioAndName)
            {
                Console.Write(LocationName.FirstName + " ");
                Console.WriteLine(LocationName.Location);
            }
        }
    }
}
