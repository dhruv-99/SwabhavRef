using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorCallAndInheritanceApp
{
    class Parent
    {
        string name;
        public Parent() 
        {
            Console.WriteLine("This is default parent constructor");
        }
        public Parent(string name) : this()
        {
            this.name = name;
            Console.WriteLine(" Parent parameterizzed constructor");
        }

      
    }
}
