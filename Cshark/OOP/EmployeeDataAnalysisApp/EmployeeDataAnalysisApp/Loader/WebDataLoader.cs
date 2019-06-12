using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using EmployeeDataAnalysisApp;
using System.IO;
using System.Security.Authentication;
namespace EmployeeDataAnalysisApp.Loader
   
{
   public class WebDataLoader : IDataLoader
    {
        
        private string _url;
        private string[] Weblines;
        private string html = string.Empty;
        private Dictionary<EmployeeOBT, EmployeeOBT> employeelistDataParser = new Dictionary<EmployeeOBT, EmployeeOBT>();
       private DataParser _parser;
        public WebDataLoader(string url)
        {
            _parser = new DataParser();
            _url = url;
        }

        public void LoadData()                //Dictionary<EmployeeOBT, EmployeeOBT> 
        {
            
            const SslProtocols _Tls12 = (SslProtocols)0x00000C00;
            const SecurityProtocolType Tls12 = (SecurityProtocolType)_Tls12;
            ServicePointManager.SecurityProtocol = Tls12;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(_url);

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }

            Weblines = html.Split('\n');
            employeelistDataParser = _parser.ParseData(Weblines);
            //return employeelistDataParser;


        }
        public Dictionary<EmployeeOBT, EmployeeOBT> GetParsedData()
        {
            return _parser.ParseData(Weblines);

        }
    }
}
