﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FoolingAround.Controllers
{
    public class StoreViewController : Controller
    {
        // GET: StoreView
        public ActionResult Index()
        {
            return View();
        }
    }
}