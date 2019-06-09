using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using EngineeringCollegeApp.SalariedEmployee;

namespace EngineeringCollegeApp
{
     class College
    {
        private int _collegeId;
        private string _collegeName;
        private string _collegeAddress;
        private ArrayList _professors;
        private ArrayList _students;

        public College(int collegeId, string collegeName, string collegeAddress)
        {
            _collegeId = collegeId;
            _collegeName = collegeName;
            _collegeAddress = collegeAddress;
            _professors = new ArrayList();
            _students = new ArrayList();
        }
        public void AddStudent(Person person)
        {
            _students.Add(person);
        }
        public void AddProfessor(Person person)
        {
            _professors.Add(person);
        }
        public int CollegeId
        {
            get
            {
                return _collegeId;
            }
        }
        public string CollegeName
        {
            get
            {
                return _collegeName;
            }
        }
        public string CollegeAddress
        {
            get
            {
                return _collegeAddress;
            }
        }
        public ArrayList Professors
        {
            get
            {
                return _professors;
            }
        }
        public ArrayList Students
        {
            get
            {
                return _students;
            }
        }
    }
}
