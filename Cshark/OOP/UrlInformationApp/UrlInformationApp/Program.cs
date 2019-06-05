using System;
using System.Collections.Generic;
using System.Text;

namespace UrlInformationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = args[0];
            Console.WriteLine(url);
            char[] spltr = { '.', '/', '?','&',';','='};
            String[] url1 = url.Split(spltr);

            for(int i =0; i < url1.Length; i++)
            {
                if(url1[i] == "www")
                {
                    Console.WriteLine("Company Name = " + url1[i+1]);
                }
                if (url1[i] == "developer")
                {
                    Console.WriteLine("Developer = " + url1[i+1]);
                }
                if (url1[i] == "location")
                {
                    Console.WriteLine("Location = " + url1[i + 1]);
                }


            }
           
           
                
           
        }
    }
}
