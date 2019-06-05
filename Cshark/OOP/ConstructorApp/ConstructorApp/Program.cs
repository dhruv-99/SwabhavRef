using System;
using System.Collections.Generic;
using System.Text;

namespace ConstructorApp
{

    class MyConstructor
    {
        private int num1 = 0, num2 = 0;
        private string name;
        public MyConstructor(int num1,int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public MyConstructor(String name)
        {
            this.name = name;
        }

        public void DisplayName()
        {

            Console.WriteLine("Name of the user is " +  name);
        }

        public void DisplayAddition()
        {

            Console.WriteLine("Addition of " + num1 + "and " + num2 + " is "+ (num1+num2));
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            MyConstructor mc = new MyConstructor(4, 5);
            MyConstructor mc2 = new MyConstructor("Dhruv");
            mc.DisplayAddition();
            mc2.DisplayName();

            Console.WriteLine("Boxing and Unboxing ::::");
            int number = 24;
            object obj = number;
            Console.WriteLine("Boxing of integer into object type");
            Console.WriteLine("Integer number = " + number);
            Console.WriteLine("after boxing, value = " + obj);
            int newnum = (int)obj;
            Console.WriteLine("Again unboxing, valuue is " + newnum);
        }
    }
}
