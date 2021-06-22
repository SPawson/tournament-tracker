using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Website.Controllers
{
    public class TournamentController : Controller
    {
        [HttpGet]
        public ActionResult Create()
        {
            return View("~/Views/Tournament/CreateTournament.cshtml");
        }

        [HttpGet]
        public ActionResult SelectTournament()
        {
            return View("~/Views/Tournament/Select.cshtml");
        }
    }
}