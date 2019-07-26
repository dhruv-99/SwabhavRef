using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace LinqApp
{
    class Program
    {
        public static string path = "C:/Windows/System32";
        static void Main(string[] args)
        {
            //   CaseStudy1();
            
            string[] directories = Directory.GetDirectories(path);
            string[] folderName = new string[directories.Length];

            int i = 0;
            for( i = 0; i < directories.Length; i++)
            {
                folderName[i] = Path.GetFileName(directories[i]);
            }

            IEnumerable<string> directoriesHavingLength5 = folderName
                .Where((a) =>
                {
                    if (a.Length >= 5)
                    {
                        return true;
                    }
                    return false;
                })
                .OrderBy((a) => a)
                .Take(3);

            

            foreach (string directory in directoriesHavingLength5)
            {
                Console.WriteLine(directory);
            } 
        }

        private static void CaseStudy1()
        {
            string[] studentName = { "Sanal", "Akash", "Dhruv", "Priyank", "Meet", "Dipesh" };
            IEnumerable<string> enumerableStudents = studentName;
            IEnumerable<string> studentNamesWithA = enumerableStudents
               .Where((s) => s.Contains('a'))
               .OrderBy((s) => s)
               .Take(2);
            foreach (string name in studentNamesWithA)
            {
                Console.WriteLine(name);
            }
        }
    }
}
