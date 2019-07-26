using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExtensionApp
{
   static class StringExtension
    {
        public static string SnakeCasing(this String s)
        {
            int n = s.Length;
            string str1 = "";

            for (int i = 0; i < n; i++)
            {
                if (s[i] == ' ')
                    str1 = str1 + '_';
                else
                    str1 = str1 + Char.ToLower(s[i]);
            }
            return str1;
        }
    }
}
