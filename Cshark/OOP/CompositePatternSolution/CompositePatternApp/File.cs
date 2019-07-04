using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePatternApp
{
    class File : IDiskItem
    {
        private string _fileName;
        private string _extension;
        private int _size;

        public File(string fileName, string extension, int size)
        {
            _fileName = fileName;
            _extension = extension;
            _size = size;
        }
        public void Display(int count)
        {
            Console.WriteLine(new string(' ', count)+ 
                "File Name = " + _fileName + " Extension = " + _extension + " Size = " + _size);
        }
    }
}
