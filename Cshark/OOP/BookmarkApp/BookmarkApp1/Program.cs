using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace BookmarkApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          Dictionary<string, string> _bookmarks = new Dictionary<string, string>();
        string url1 = "https://www.google.com";
        string url2 = "https://www.yahooo.com";
        string url3 = "https://www.wikipedia.com";
        string value1 = "google";
        string value2 = "yahoo";
        string value3 = "wikipedia";
        _bookmarks.Add(url1, value1);
            _bookmarks.Add(url2, value2);
            _bookmarks.Add(url3, value3);
            using (FileStream fs = new FileStream("C://Users/Toshiba/Desktop/test.htm", FileMode.Create))
            {
                using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                {
                    foreach (KeyValuePair<string, string> bookmark in _bookmarks)

                        w.WriteLine("<a href=" + bookmark.Value +">"+bookmark.Key +"</a><br>");
                }
            }
        }
    }
}
