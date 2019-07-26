using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CallBackApp
{
    class Program
    {
        public delegate void DCallBack(string s);
        static void FnSucess(string success)
        {
            Console.WriteLine("successful result = " + success);
        }
        static void FnError(string error)
        {
            Console.WriteLine("error =" + error);
        }
        static void CubeEvenno(int number, DCallBack fnsuccess, DCallBack fnerror)
        {
            int result = 0;
            if (number % 2 == 0)
            {
                result = number * number * number;
                fnsuccess(result.ToString());
            }
            else
            {
                fnerror("It is not even no");
            }

        }
        static void Main(string[] args)
        {
            //CubeEvenno(3, FnSucess, FnError);

            //  CubeEvenno(4, (s) => { Console.WriteLine(s); },
            //      (e) => { Console.WriteLine(e); });

            DCallBack result = (s) => { Console.WriteLine
                ("Displayed string is " + s); };
            result("Hello");

        }
    }
}