using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace CollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();

            // CaseStudy2();

            //  CaseStudy3();

            //  CaseStudy4();

            Dictionary<Student, Student> studentDetails = new Dictionary<CollectionApp.Student, CollectionApp.Student>();
            Student akash = new Student(1, 10, "Akash");
            Student sanal = new Student(2, 10, "Sanal");
            Student dipesh = new Student(3, 10, "Dipesh");
            studentDetails.Add(akash, akash);
            studentDetails.Add(sanal, sanal);
            studentDetails.Add(dipesh, sanal);
            if (studentDetails.ContainsKey(dipesh))
            {
  

            Student dipesh2 = new Student(3, 10, "Dipesh");
            studentDetails.Add(dipesh2, dipesh2);
            Console.WriteLine(studentDetails.Count);
            {

            }
        }

        private static void CaseStudy4()
        {
            HashSet<Student> studentDetails = new HashSet<Student>();
            studentDetails.Add(new Student(1, 10, "Dhruv"));
            studentDetails.Add(new Student(10, 1, "Sanal"));
            Console.WriteLine(studentDetails.Count);
        }


        private static void CaseStudy3()
        {
            HashSet<LineItem> cart = new HashSet<LineItem>();
            cart.Add(new LineItem("Buscuit", 2, 10));
            cart.Add(new LineItem("mango", 2, 10));
            cart.Add(new LineItem("Buscuit", 2, 10));
            Console.WriteLine(cart.Count);
        }

        private static void CaseStudy2()
        {
            List<LineItem> cart = new List<LineItem>();
            cart.Add(new LineItem("Buscuit", 2, 10));
            cart.Add(new LineItem("Juice", 3, 20));
            cart.Add(new LineItem("Mango", 6, 30));
            cart.Add(new LineItem("Pen", 10, 10));
            foreach (LineItem item in cart)
            {
                Console.WriteLine("Total = " + item.CalculatePrice());
            }
        }

        private static void CaseStudy1()
        {
            ArrayList cart = new ArrayList();
            cart.Add(new LineItem("Buscuit", 2, 10));
            cart.Add(new LineItem("Juice", 3, 20));
            cart.Add(new LineItem("Mango", 6, 30));
            cart.Add(new LineItem("Pen", 10, 10));
            cart.Add("Dhruv");
            cart.Add(500);
            cart.Add(true);

            foreach (LineItem element in cart)
            {
                Console.WriteLine(element.ProductName);
            }
        }
    }
}
