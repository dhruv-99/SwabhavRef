using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace ContactApp
{
    public class PhoneBook
    {
        public static string path = @"S:\\Swabhhav techlabs\usercontact.txt";
        public string filepath = @"S:\\Swabhhav techlabs\ExportContact.csv";
        private List<Contact> _contactList;
        public PhoneBook()
        {

            _contactList = new List<Contact>();
        }
        public void AddContact(string name, string email, string phoneNumber)
        {
            Contact contact = new Contact(name, email, phoneNumber);
           _contactList = RetrieveContact();
            _contactList.Add(contact);
            StoreContact(_contactList);
        }
        public List<Contact> SearchContact(string searchContact)
        {
            _contactList = RetrieveContact();

            List<Contact> MatchingContacts = new List<Contact>();
            foreach (Contact c in _contactList)
            {
                if ((c.Name).Equals(searchContact) || (c.Email).Equals(searchContact) || (c.PhoneNumber).Equals(searchContact))
                {
                    MatchingContacts.Add(c);
                }
            }
            return MatchingContacts;
        }
        public void ExportContact()
        {
            _contactList = RetrieveContact();
            StringBuilder stringbuilder = new StringBuilder();
            foreach (Contact c in _contactList)
            {
                stringbuilder.AppendLine(c.Name + "," + c.Email + "," + c.PhoneNumber);
            }
            File.WriteAllText(filepath, stringbuilder.ToString());
        }
        public static void StoreContact(List<Contact> contactlist)
        {
            using (FileStream filestreamer = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binfomatter = new BinaryFormatter();
                binfomatter.Serialize(filestreamer, contactlist);
            }
        }
        public static List<Contact> RetrieveContact()
        {
            using (FileStream filestreamer = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter binformatter = new BinaryFormatter();
                return (List<Contact>)binformatter.Deserialize(filestreamer);
            }
        }
        public List<Contact> ContactList
        {
            get
            {
                return _contactList;
            }
        }



    }
}

