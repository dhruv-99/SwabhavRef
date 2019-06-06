using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ContactApp
{
    class Program
    {
      
        static void Main(string[] args)
        {
            PhoneBook phonebook = new PhoneBook();

            Console.WriteLine("1 - Add new contact");
            Console.WriteLine("2 - Display contacts");
            int choice = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (choice == 1)
                {

                    Console.WriteLine("Enter the name :");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter the email_id :");
                    string email = Console.ReadLine();
                    Console.WriteLine("Enter the contact :");
                    string phonenumber = Console.ReadLine();

                    phonebook.AddContact(name, email, phonenumber);
                    Console.WriteLine("Do you want to continue");
                }
                if (choice == 2)
                {

                    display();

                }
                if (choice == 0)
                    break;
                Console.WriteLine("1 - Add new contact");
                Console.WriteLine("2 - Display contacts");
                Console.WriteLine("0 - Exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
        public static void display()
        {
            ArrayList phonediary = PhoneBook.DeserializeContact();
            foreach (Contact c in phonediary)
            {
                Console.WriteLine("Name = " + c.Name);
                Console.WriteLine("Email = " + c.Email);
                Console.WriteLine("Phone Number = " + c.PhoneNumber);
                Console.WriteLine();

            }
        }
    }
}



