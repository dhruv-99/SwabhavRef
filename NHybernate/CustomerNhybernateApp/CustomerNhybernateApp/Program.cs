using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace CustomerNhybernateApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Configuration config = new Configuration();
            config.Configure();
            config.AddAssembly(typeof(Customer).Assembly);
            var sessionFactory = config.BuildSessionFactory();
            using (var session = sessionFactory.OpenSession())
            {
                using (var transaction = session.BeginTransaction())
                {
                    var customer1 = new Customer
                    {
                        FirstName = "Dhruv",
                        LastName = "Ballikar"
                    };
                    var customer2 = new Customer
                    {
                        FirstName = "Akash",
                        LastName = "Jaiswal"
                    };
                    var customer3 = new Customer
                    {
                        FirstName = "Sanal",
                        LastName = "Dhamanse"
                    };
                    session.Save(customer1);
                    session.Save(customer2);
                    session.Save(customer3);
                    transaction.Commit();
                }
            }

        }
    }
}
