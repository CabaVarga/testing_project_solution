﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace testing_project.Controllers
{
    public class HomeController : ApiController
    {
        public string GetGreeting()
        {
            return "Hello World";
        }
    }
}
