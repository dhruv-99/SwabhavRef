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
        private ArrayList _contactList;
        public PhoneBook()
        {

            _contactList = new ArrayList();
        }
        public void AddContact(string name, string email, string phoneNumber)
        {
            Contact contact = new Contact(name, email, phoneNumber);
            _contactList = DeserializeContact();
            _contactList.Add(contact);
            SerializeContact(_contactList);
        }
        public static void SerializeContact(ArrayList contactlist)
        {
            using (FileStream filestreamer = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                BinaryFormatter binfomatter = new BinaryFormatter();
                binfomatter.Serialize(filestreamer, contactlist);
            }
        }
        public static ArrayList DeserializeContact()
        {
            using (FileStream filestreamer = new FileStream(path, FileMode.Open))
            {
                BinaryFormatter binformatter = new BinaryFormatter();
                return (ArrayList)binformatter.Deserialize(filestreamer);
            }
        }
        public ArrayList ContactList
        {
            get
            {
                return _contactList;
            }
        }
        
       

    }
}

