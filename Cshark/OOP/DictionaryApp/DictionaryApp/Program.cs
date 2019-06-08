using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentDictionary dictionary = new StudentDictionary();
           
            do
            {
                Console.WriteLine("Enter 1 to Add");
                Console.WriteLine("Enter 2 to Update");
                Console.WriteLine("Enter 3 to Search");
                Console.WriteLine("Enter 4 to Delete");
                Console.WriteLine("Enter 5 to Display");
                int choice = Convert.ToInt32(Console.ReadLine());
                if(choice == 1)
                {
                    dictionary.Add();
                    Console.WriteLine("Data is Added");
                }
                if(choice == 2)
                {
                    dictionary.Update();
                    Console.WriteLine("Update Successfull");
                }
                if(choice == 3)
                {
                    dictionary.Search();
                }
                if(choice == 4)
                {
                    dictionary.Delete();
                }
                if(choice == 5)
                {
                    Display(dictionary._student);
                }
                if(choice == 0)
                {
                    break ;
                }
            }
            while (true);
        }
            
        public static void Display(Dictionary<int,string> dictionary)
        {
            foreach(KeyValuePair<int,string> element in dictionary)
            {
                Console.WriteLine(element.Key+element.Value);
            }
        }
    }
}
