using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LambdaApp
{
    class Program
    {
        static void FnSucess(string success)
        {
            Console.WriteLine("successful result = " + success);
        }
        static void FnError(string error)
        {
            Console.WriteLine("error =" + error);
        }
        static void CubeEvenno(int number, Action<string> fnsuccess, Action<string> fnerror)
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
       //   CubeEvenno(2,FnSucess,FnError);

            Predicate<int> IsPrime = (num) =>
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num == 1)
                        return true;
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            };
           Console.WriteLine(IsPrime(11));

            
        }
    }
}
