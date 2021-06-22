using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class PersonController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}