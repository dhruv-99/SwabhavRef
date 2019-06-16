using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace BookmarkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bookmark bookmark = new Bookmark();
            bookmark.AddUrl("https://www.google.com", "google");
            bookmark.AddUrl("https://www.yahooo.com", "yahoo");
            bookmark.AddUrl("https://www.wikipedia.com", "wikipedia");

            foreach (KeyValuePair<string, string> consoleBookmark in bookmark.Bookmarks)
            {
                Console.WriteLine(consoleBookmark.Key);
            }

            Console.WriteLine("Press E to Export bookmarks");
            string userChoice = Console.ReadLine();
            if (userChoice.Equals("E"))
            {
                using (FileStream fs = new FileStream("S://Swabhhav techlabs/bookmark.htm", FileMode.Create))
                {
                    using (StreamWriter w = new StreamWriter(fs, Encoding.UTF8))
                    {
                        foreach (KeyValuePair<string, string> bookmark1 in bookmark.Bookmarks)

                            w.WriteLine("<a href=" + bookmark1.Key + ">" + bookmark1.Value + "</a><br>");
                    }
                }
                Console.WriteLine("Data Exported");
            }
        }
    }
}
