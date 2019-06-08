using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerableIEnumerratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> Days = new List<string>();
            Days.Add("Monday");
            Days.Add("Tuesday");
            Days.Add("Wednesday");
            Days.Add("Thursday");
            Days.Add("Friday");
            Days.Add("Saturday");
            Days.Add("Sunday");

            IEnumerable<string> Weekdays = (IEnumerable<string>)Days;
            foreach (string day in Weekdays)
            {
                Console.WriteLine(day);
            }
            IEnumerator<string> Day = Days.GetEnumerator();  

            while (Day.MoveNext())
            {
                Console.WriteLine(Day.Current);
            }
        }
        
    }
}
