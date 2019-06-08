using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using InterfaceApp.Crud;
using InterfaceApp.Vehicle;
namespace InterfaceApp

{
    class Program
    {
        static void Main(string[] args)
        {
            // CaseStudy1();


            CaseStudy2();
        }

        private static void CaseStudy2()
        {
            IMovable[] movable = new IMovable[3];
            movable[0] = new Car();
            movable[1] = new Bike();
            movable[2] = new Truck();
            StartRace(movable);
        }

        public static void StartRace(IMovable[] movable)
        {
            Console.WriteLine("Inside race method..");
            for(int i = 0; i < 3; i++)
            {
                movable[i].Move();
            }  
           
        }






        private static void CaseStudy1()
        {
            DoDbOpperation(new CustomerDb());
            DoDbOpperation(new DepartmentDb());
            DoDbOpperation(new InvoiceDb());
        }

        public static void DoDbOpperation(ICrudable crudOp)
        {
            Console.WriteLine("Inside Db operation");
            crudOp.Create();
            crudOp.Read();
            crudOp.Update();
            crudOp.Delete();
        }
    }
}
