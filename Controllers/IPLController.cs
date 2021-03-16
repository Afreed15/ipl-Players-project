using ProjectCheck.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectCheck.Controllers
{
    public class IPLController : Controller
    {
        
        public ActionResult Teams()
        {
            IPLCheckEntities db = new IPLCheckEntities();

            return View(db.Teams.ToList());
        }
        public ActionResult LPlayers(int id)
        {
            IPLCheckEntities db = new IPLCheckEntities();
            List<Player> Playerlist = db.Players.Where(x => x.Tid == id).ToList();
            return View(Playerlist);
        }
        public ActionResult PDetails(int id)
        {
            IPLCheckEntities db = new IPLCheckEntities();
            List<PProfile> Playerlist = db.PProfiles.Where(x => x.Pid == id).ToList();
            return View(Playerlist);
        }
    }
}