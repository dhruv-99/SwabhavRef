using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.BusinessModel;
using WelcomeMVCApp.Repositories;

namespace WelcomeMVCApp.Services
{
    public class StudentServices
    {
        public StudentRepo repo;
        public StudentServices()
        {
            repo = new StudentRepo();
        }
      



        public List<Student> Get
        {
            get
            {
                return repo.Get();
            }

        }
        public int Count
        {
            get
            {
                return repo.Count();
            }
        }
        public void Add(Models.Student.AddViewModel addViewModel)
        {
            Student student = new Student()
            {
                RollNumber = addViewModel.RollNumber,
                Name = addViewModel.Name,
                CGPI = addViewModel.CGPI,
                Location = addViewModel.Location,
                DateOfBirth = addViewModel.DateOfBirth
            };
            repo.Add(student);
        }
        public Student GetById(string id)
        {
            return repo.GetById(id);
        }
        public void EditStudent(Models.Student.EditViewModel evmStudent)
        {
            Student student = new Student();
            student.RollNumber = evmStudent.RollNumber;
            student.Name = evmStudent.Name;
            student.CGPI = evmStudent.CGPI;
            student.Location = evmStudent.Location;
            student.DateOfBirth = evmStudent.DateOfBirth;
            repo.Edit(student);
        }
    public void DeleteStudent(Student student)
    {
        repo.Delete(student);
    }
}
}