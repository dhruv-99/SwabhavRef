using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;


namespace EmployeeDataAnalysisApp.Loader
{
    public class CSVLoader :IDataLoader
    {
       private DataParser _parser;        
        private readonly string path = @"S:\Swabhhav techlabs\dataFile.txt";
        List<string> _csvDataLoader;
        string[] lines;
        public CSVLoader()
        {
            _parser = new DataParser();
            _csvDataLoader = new List<string>();
        }
        public void LoadData()
        {
            lines = File.ReadAllLines(path);
           
        }

        public Dictionary<EmployeeOBT,EmployeeOBT> GetParsedData()
        {
            return _parser.ParseData(lines);
            
        }

        /*public void Display()
        {
            foreach(string val in _csvDataLoader)
            {
                Console.WriteLine(val);
            }       
        }*/
    }
}
