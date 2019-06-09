using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EngineeringCollegeApp
{
    class Student : Person
    {
        private Branches _branch;

        public Student(int id,string address, DateTime dob, Branches branch) : base(id,address,dob)
        {
            _branch = branch; ;
        }
        public override string ToString()
        {
            return base.ToString()+"\nBranch = "+Branch;
        }
        public Branches Branch
        {
            get
            {
                return _branch; 
            }
        }
    }
    
}
