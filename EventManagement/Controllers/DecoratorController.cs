using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    public class DecoratorController : Controller
    {
        EventCtx eventCtx = new EventCtx();
        // GET: Decorator
        public ActionResult Index()
        {
            var data = from p in eventCtx.decorators select p;
            return View(data.ToList());        
        }
        public ActionResult GetDecorator(int id)
        {
            var x = from n in eventCtx.decorators where n.DecoratorID == id select n;
            return View(x);
        }
    }
}