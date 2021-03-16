using ProjectCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCheck.Controllers
{
    public class PlayersController : Controller
    {
        // GET: Players
        public ActionResult Index()
        {
            IPLCheckEntities db = new IPLCheckEntities();
            return View(db.PProfiles.ToList());
        }
    }
}