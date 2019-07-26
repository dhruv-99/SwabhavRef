using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WelcomeMVCApp.BusinessModel;

namespace WelcomeMVCApp.Repositories
{
    public class StudentRepo
    {
        public static AurionProEFDBContext _context;

         static StudentRepo() {
            _context = new AurionProEFDBContext();
        }

        public List<Student> Get()
        {
            var query = _context.Students.ToList();
            return query;
        }

        public Student GetById(string id)
        {
            var query = _context.Students.Find(id);
            return query;
        }

        public void Add(Student student)
        {
            var query = _context
                .Students.Add(student);
            _context.SaveChanges();
        }

        public void Edit(Student student)
        {
            var query = _context.Students
                .SingleOrDefault((s) => s.RollNumber.Equals(student.RollNumber));

            query.RollNumber = student.RollNumber;
            query.Name = student.Name;
            query.CGPI = student.CGPI;
            query.Location = student.Location;
            query.DateOfBirth = student.DateOfBirth;
            _context.SaveChanges();
        }

        public void Delete(Student student)
        {
            var query = _context.Students.Remove(student);
            _context.SaveChanges();
        }

        public int Count()
        {
            var query = _context.Students.Count();
            return query;
        }
    }
}