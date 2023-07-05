using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject3.Controllers
{
    public class ParamsController : Controller
    {
        // GET: Params
        public string Index1(int id)
        {
            return "the value of id is " + id;
        }
        public string Index2(int id=0)
        {
            return "the value of id is " + id;
        }
        public string Index3(int? id)
        {
            return "the value of id is " + id;
        }
        public string Index4(int x)
        {
            return "the value of id is " + x;
        }
        public string Index5(int? id,string name)
        {
            return $"value of id is {id} and value of name is {name}";
        }
    }
}