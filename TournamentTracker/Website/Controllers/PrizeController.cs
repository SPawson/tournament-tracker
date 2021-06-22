using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class PrizeController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
    }
}