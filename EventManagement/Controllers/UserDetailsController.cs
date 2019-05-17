using EventManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    public class UserDetailsController : Controller
    {
        EventCtx eventCtx = new EventCtx();
        // GET: UserDetails
        public ActionResult Index()
        {
            var data = from p in eventCtx.users select p;
            return View(data.ToList());
        }    
        
        public ActionResult GetUser(int id)
        {
            var x = from n in eventCtx.users where n.UserID == id select n;
            return View(x);
        }
    }
}