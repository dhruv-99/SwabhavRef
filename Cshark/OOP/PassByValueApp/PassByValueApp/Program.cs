using System;
using System.Collections.Generic;
using System.Text;

namespace PassByValueApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int mark = 100;
            ChangeMarkToZero(mark);
            Console.WriteLine(mark);
            int[] marks = {10,20,30};
            ChangeMarksToZero(marks);
            foreach (int m in marks)
            Console.WriteLine(m);
        }

        protected static void ChangeMarkToZero(int mark)
        {
            mark = 0;
        }

        protected static void ChangeMarksToZero(int[] marks)
        {
            for(int i = 0; i < marks.Length; i++)
            {
                marks[i] = 0;
            }
        }
    }
}
