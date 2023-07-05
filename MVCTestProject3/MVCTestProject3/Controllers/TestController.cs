using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVCTestProject3.Controllers
{
    public class TestController:Controller
    {
        public string Index()
        {
            return "this is Test controller - Index Method";
        }
        public string Hello()
        {
            return "this is Test controller - Hellos Method";
        }
    }
}