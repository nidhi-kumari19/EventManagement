using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    public class CateringController : Controller
    {
        EventCtx eventCtx = new EventCtx();
        // GET: Catering
        public ActionResult Index()
        {
            var data = from p in eventCtx.caterings select p;
            return View(data.ToList());
        }
        public ActionResult GetCaterer(int id)
        {
            var x = from n in eventCtx.caterings where n.CateringID == id select n;
            return View(x);
        }
    }
}