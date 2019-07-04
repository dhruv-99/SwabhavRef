using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternApp
{
    class Folder : IDiskItem
    {
        private string _folderName;
        private List<IDiskItem> _contents;
        
        public Folder(string folderName)
        {
            _folderName = folderName;
            _contents = new List<IDiskItem>();
        } 
        public void Display(int count)
        {
            Console.Write(new String(' ',count));
            Console.WriteLine("Folder name = " + _folderName);
            foreach (IDiskItem content in _contents)
            {
                content.Display(count+3);
            }
        }
        public void AddItem(IDiskItem content)
        {
            _contents.Add(content);
        }

    }
}
