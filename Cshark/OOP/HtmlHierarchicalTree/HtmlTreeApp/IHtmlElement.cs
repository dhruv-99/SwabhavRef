using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HtmlTreeApp
{
    interface IHtmlElement
    {
        string ParseToHtml(int count); 
    }
}
