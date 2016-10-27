using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Keys.Controllers
{
    public class AnotherController : Controller
    {
        // GET: Another
        public ActionResult Index(string name = "jas", int id = 3)
        {
            ViewBag.Name = name;
            ViewBag.Id = id;
            return View();
        }

        public ActionResult Yaaa()
        {
            ViewBag.Message = "Jasmine Rules The World";
            return View();
        }
    }
}