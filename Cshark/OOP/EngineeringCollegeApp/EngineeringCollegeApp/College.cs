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
        private List<Professor> _professors;
        private List<Student> _students;

        public College(int collegeId, string collegeName, string collegeAddress)
        {
            _collegeId = collegeId;
            _collegeName = collegeName;
            _collegeAddress = collegeAddress;
            _professors = new List<Professor>();
            _students = new List<Student>();
        }
        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
        public void AddProfessor(Professor professor)
        {
            _professors.Add(professor);
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
        public List<Professor> Professors
        {
            get
            {
                return _professors;
            }
        }
        public List<Student> Students
        {
            get
            {
                return _students;
            }
        }
    }
}
