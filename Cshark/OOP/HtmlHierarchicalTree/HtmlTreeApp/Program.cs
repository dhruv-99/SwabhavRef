using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ControlGroup controlGroup = new ControlGroup("div");
            ControlGroup controlGroup1 = new ControlGroup("div", "d1");


            Control control = new Control("H1","button","Hello I Am  Dhruv");
            Control control1 = new Control("p", "paragraph", "Who are you?");
            controlGroup1.AddChild(control1);
            controlGroup.AddChild(control);
            controlGroup.AddChild(controlGroup1);
            
            
            Console.WriteLine(controlGroup.ParseToHtml(4));
        }
    }
}
