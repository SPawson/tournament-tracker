using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrackerLibrary.Classes;
using TrackerLibrary.Models;

namespace Website.Controllers
{
    public class PrizeController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(PrizeModel model)
        {
            if (ModelState.IsValid)
            {
                foreach (var db in GlobalConfig.Connections)
                {
                    var prize = db.CreatePize(model);
                }

                return View();
            }

            return View();
        }

    }
}