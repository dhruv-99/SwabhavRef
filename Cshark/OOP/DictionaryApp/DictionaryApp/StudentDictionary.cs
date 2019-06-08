using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DictionaryApp
{
    class StudentDictionary
    {
       public Dictionary<int, String> _student;

        public StudentDictionary()
        {
            _student = new Dictionary<int, string>();
        }
        public void Add()
        {
            _student.Add(1, "Dhruv");
            _student.Add(2, "Akash");
            _student.Add(3, "Sanal");
        }
        public void Search()
        {
            if (_student.ContainsValue("Sanal"))
            {

                Console.WriteLine("Student found");
            }
        }
        public void Delete()
        {
            _student.Remove(3);
        }
        public void Update()
        {
            _student[1] = "Dipesh";
        }
    }
}
