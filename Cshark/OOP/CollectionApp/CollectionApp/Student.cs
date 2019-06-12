using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CollectionApp
{
    class Student
    {
        private int _rollNo;
        private int _standard;
        private string _name;

        public Student(int rollNo, int standard, string name)
        {
            _rollNo = rollNo;
            _standard = standard;
            _name = name;
        }
        public override bool Equals(object obj)
        {
            Student student1 = (Student)obj;
            if ((student1._rollNo == this._rollNo) && (student1._standard == this._standard))
                return true;
            else
                return false;
        }
        public override int GetHashCode()
        {
            return 1;
        }
    }
}
