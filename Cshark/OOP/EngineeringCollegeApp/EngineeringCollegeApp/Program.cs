using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EngineeringCollegeApp.SalariedEmployee;

namespace EngineeringCollegeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person amit = new Professor(101, "Mira Road", new DateTime(1997, 02, 05), 50000);
            Person akash = new Student(102, "Dadar", new DateTime(1996, 07, 20), Branches.COMPUTER_ENGINEERING);
            College vit = new College(001, "VIT", "Wadala");
            do
            {
                Console.WriteLine("Press 1 to display Person details :");
                Console.WriteLine("Press 2 to display College details :");
                Console.WriteLine("Press 3 to display Professor details :");
                Console.WriteLine("Press 4 to display Student details :");
                Console.WriteLine("Press 5 to Add Professor to college :");
                Console.WriteLine("Press 6 to Add student to college :");
                Console.WriteLine("Press 0 to EXIT :");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.WriteLine(amit.ToString());
                    Console.WriteLine(akash.ToString());
                }
                if (choice == 2)
                {
                    Console.WriteLine("College details :");
                    Console.WriteLine("College id = " + vit.CollegeId);
                    Console.WriteLine("College Name = " + vit.CollegeName);
                    Console.WriteLine("College Address = " + vit.CollegeAddress);
                }
                if (choice == 3)
                {
                    Console.WriteLine("Professor details :::");
                    foreach (Professor professor in vit.Professors)
                    {
                        Console.WriteLine("Professor ID = " + professor.Id);
                        Console.WriteLine("Professor Address = " + professor.Age);
                        Console.WriteLine("professor Date of Birth = " + professor.DateOfBirth);
                        Console.WriteLine("Professor Age = " + professor.Age);
                        Console.WriteLine("Professor Salary = " + professor.Salary);
                    }
                }
                if (choice == 4)
                {
                    Console.WriteLine("Student Details :::");
                    foreach (Student student in vit.Students)
                    {
                        Console.WriteLine("Student ID = " + student.Id);
                        Console.WriteLine("Student Address = " + student.Address);
                        Console.WriteLine("Student Date of Birth = " + student.DateOfBirth);
                        Console.WriteLine("Student Age = " + student.Age);
                        Console.WriteLine("Student Branch = " + student.Branch);
                    }
                }
                if (choice == 5)
                {
                    vit.AddProfessor(amit);
                    Console.WriteLine("Professor added successfully..");
                }
                if (choice == 6)
                {
                    vit.AddStudent(akash);
                    Console.WriteLine("Student added successfully..");
                }
                if (choice == 0)
                    break;
            }
            while (true);
        }
    }
}
