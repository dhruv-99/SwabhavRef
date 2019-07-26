using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImmediateExecutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var student1 = new Student()
            { FirstName = "Sanal", LastName = "Dhamanse", Cgpi = 7.5, Location = "Raigad" };
            var student2 = new Student()
            { FirstName = "Akash", LastName = "Jaiswal", Cgpi = 8.1, Location = "Prabhadevi"};
            var student3 = new Student()
            { FirstName = "Dhruv", LastName = "Ballikar", Cgpi = 7.9, Location = "Mumbai" };
            var student4 = new Student()
            { FirstName = "Priyank", LastName = "Shah", Cgpi = 5.9, Location = "Mumbai" };

            IList<Student> studentList = 
                new List<Student> { student1, student2, student3, student4 };

            var studentsHavingHighCGPI = studentList
                .Where((stud) => stud.Cgpi > 7)
                .Select((s) => new { s.FirstName, s.Cgpi })
                .ToList();

            foreach (var student in studentsHavingHighCGPI)
            {
                Console.WriteLine(student.FirstName + " " + student.Cgpi);
            }

            Console.WriteLine();

            var student5 = new Student()
            { FirstName = "Priyank", LastName = "Shah", Cgpi = 7.4, Location = "Mumbai" };
            studentList.Add(student5);
            foreach (var student in studentsHavingHighCGPI)
            {
                Console.WriteLine(student.FirstName + " " + student.Cgpi);
            }
        }
    }
}
