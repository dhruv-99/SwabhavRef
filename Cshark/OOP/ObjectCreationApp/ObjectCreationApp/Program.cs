using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectCreationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);
            object obj = Activator.CreateInstance(type);
            Student student = obj as Student;
            student.Print(); 
        }
    }
}
