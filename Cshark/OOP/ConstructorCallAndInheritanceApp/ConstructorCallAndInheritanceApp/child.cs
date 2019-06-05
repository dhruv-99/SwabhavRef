using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorCallAndInheritanceApp
{
    class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("This is child default constructor");
        } 
        public Child(String last_name) :base(last_name)
            
        {
            
            Console.WriteLine("This is child parameterized  constructor");
        }
            
    }
}
