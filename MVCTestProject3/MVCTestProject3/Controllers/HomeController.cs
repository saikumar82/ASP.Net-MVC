﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTestProject3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "this is home controller - index action methods";
        }
    }
}