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
            Console.WriteLine("3 - Search contact");
            Console.WriteLine("4 - Export contact");
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
                if (choice == 3)
                {
                    Console.WriteLine("Enter Name, Email or Phone Number :");
                    string searchContact = Console.ReadLine();
                    List<Contact> MatchingContacts = phonebook.SearchContact(searchContact);
                   
                    foreach (Contact con in MatchingContacts)
                    {
                        Console.WriteLine("Name = " + con.Name);
                        Console.WriteLine("Email = " + con.Email);
                        Console.WriteLine("Phone Number = " + con.PhoneNumber);
                    }
                }
                if(choice ==4)
                {
                    phonebook.ExportContact();
                }
                if (choice == 0)
                    break;
                Console.WriteLine("1 - Add new contact");
                Console.WriteLine("2 - Display contacts");
                Console.WriteLine("3 - Search contact");
                Console.WriteLine("4 - Export contact");
                Console.WriteLine("0 - Exit");
                choice = Convert.ToInt32(Console.ReadLine());
            }

        }
        public static void display()
        {
            List<Contact> phonediary = PhoneBook.RetrieveContact();
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



