using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HumanApp;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ArraylistApp
{
    class Program
    {
        private static string path = @"S:\\Swabhav Techlabs\HumanObject.text";
        static void Main(string[] args)
        {

            Human human1 = new Human("Dhruv", 6.0f, 53f, 18);
            Human human2 = new Human("Akash", 5.6f, 45f, 21);
            ArrayList human = new ArrayList();
            human.Add(human1);
            human.Add(human2);
            SerializeHuman(human);
        }

        public static void SerializeHuman(ArrayList human)
        {
            FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
            BinaryFormatter binformatter = new BinaryFormatter();
            binformatter.Serialize(fs, human);
            Console.WriteLine("Your data is serialized...");
        }
        public static void DeserializeHuman()
        {
            FileStream fs = new FileStream(path, FileMode.Open);
            BinaryFormatter binformatter = new BinaryFormatter();
            binformatter.Deserialize(fs);
            Human = (ArrayList)
            
            Console.WriteLine("Your data is serialized...");
        }
    }
}
