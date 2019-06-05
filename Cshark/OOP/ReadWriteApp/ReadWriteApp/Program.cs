using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ReadWriteApp
{
    class Program
    {
        static readonly string textFile = @"S:\Swabhhav techlabs\text1.txt";
        static void Main(string[] args)
        {

            //   string[] name = new string[] { "Dog", "cat" };

            WriteFile();
            ReadFile();

        }

        static void WriteFile()
        {
            using (FileStream fs = new FileStream(textFile, FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            {

                Console.WriteLine("Enter the text");
                string text = Console.ReadLine();
                sw.WriteLine(text);


            }


        }
        static void ReadFile()
        {
            using (StreamReader sr = new StreamReader(textFile))
            {
                string content;
                while ((content = sr.ReadLine()) != null)
                {
                    Console.WriteLine(content);
                }
            }
        }

    }
}
