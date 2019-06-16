using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookmarkApp
{
    class Bookmark
    {
        private Dictionary<string, string> _bookmarks;

        public Bookmark()
        {
            _bookmarks = new Dictionary<string, string>();
        }
        public void AddUrl(string url,string description)
        {
            _bookmarks.Add(url, description);
        }
        public Dictionary<string,string> Bookmarks
        {
            get
            {
                return _bookmarks;
            }
        }
    }
}
