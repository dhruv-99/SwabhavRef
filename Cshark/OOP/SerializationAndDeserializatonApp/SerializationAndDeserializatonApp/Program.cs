using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using HumanApp;
namespace SerializationAndDeserializatonApp
{
    class Program
    {
        private static string path = @"S:\Swabhhav techlabs\SerializedObject.txt";
        static void Main(string[] args)
        {
            Human human1 = new Human("Dhruv", 6.2f, 50f, 18);
            SerializeData(human1);
            Console.WriteLine("Object serialized successfully");
            human1.Eat();
            Console.WriteLine("name = "+human1.Name + "\n Height = "+human1.Height + "\n Weight = "+human1.Weight + "\n Age = "+human1.Age);
            DeserializeData();
        }

        public static void SerializeData(Human human1)
        {
           
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter binformat = new BinaryFormatter();
            binformat.Serialize(fs, human1);
            fs.Close();
        }

        public static void DeserializeData()
        {
            
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter binformat = new BinaryFormatter();
            Human data = (Human)binformat.Deserialize(fs);
            fs.Close();
            Console.WriteLine("Your deserialized data is ");
            Console.WriteLine(data);
        }
    }
}
