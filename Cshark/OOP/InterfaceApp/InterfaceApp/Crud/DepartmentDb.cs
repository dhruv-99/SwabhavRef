using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceApp.Crud
{
    class DepartmentDb : ICrudable
    {
        public void Create()
        {
            Console.WriteLine("Department created");
        }
        public void Read()
        {
            Console.WriteLine("Deartment Data read");
        }
        public void Update()
        {
            Console.WriteLine("Department update");
        }
        public void Delete()
        {
            Console.WriteLine("Depatment Deleted");
        }
    }
}
