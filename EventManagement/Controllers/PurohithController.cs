using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    public class PurohithController : Controller
    {
        EventCtx eventCtx = new EventCtx();

          // GET: Purohith
          [HttpGet]
        public ActionResult Index()
        {
            //var data = from p in eventCtx.purohiths select p;
            return View();
        }
        public ActionResult GetPurohith(int id)
        {
            var x = from n in eventCtx.purohiths where n.PurohithID ==id select n;
            return View(x);
        }
        [HttpPost]
        public ActionResult AddPurohith(Purohith p)
        {
            eventCtx.purohiths.Add(p);
            eventCtx.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}