using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TunisiaMall.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public string Index()
        {
            return @"<html><body><p><h1>hello ! </h1></p></body></html>";
        }
        public string welcom(int a, string b)
        {
            return HttpUtility.HtmlEncode("test" + a + b);
        }
    }
}