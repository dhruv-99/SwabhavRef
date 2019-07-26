using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityApp
{
    class Program
    {
       static SwabhavEFDBContext dbcontext = new SwabhavEFDBContext();
        static void Main(string[] args)
        {
            //  Create();

            //  ienumerableQuery();


            //  Update();

            //var deleteQuery = dbcontext.Students.First<Student>();
            //dbcontext.Students.Remove(deleteQuery);
            //dbcontext.SaveChanges();

            var stud = dbcontext.Students.Find("176ED643 - 3FF4 - 4130 - 989A - 192FAE877C42");
            dbcontext.Students.Remove(stud);
            dbcontext.SaveChanges();


        }

        private static void Update()
        {
            var updateQuery = dbcontext.Students.First<Student>();
            updateQuery.AGE = 23;
            dbcontext.SaveChanges();
        }

        private static void Create()
        {
            var s1 = new Student()
            {
                ID = Guid.NewGuid(),
                NAME = "Sanal",
                CGPI = 9.89f,
                LOC = "Wadala"
            };
            var s2 = new Student()
            {
                ID = Guid.NewGuid(),
                NAME = "Akash",
                CGPI = 8.79f,
                LOC = "Dadar"
            };
            var s3 = new Student()
            {
                ID = Guid.NewGuid(),
                NAME = "Dhruv",
                CGPI = 7.89f,
                LOC = "Mira Road"
            };
            dbcontext.Students.Add(s1);
            dbcontext.Students.Add(s2);
            dbcontext.Students.Add(s3);
            dbcontext.SaveChanges();
        }

        public static void ienumerableQuery()
        {
            var query = dbcontext.Students
                .Where(a => a.NAME.Contains("a"));


            var query1 = query.Take(3)
                .Select((m) => new { name = m.NAME.ToUpper(), m.CGPI }).ToList();
          
        }
    }
    }
