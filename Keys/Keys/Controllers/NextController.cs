using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Keys.Controllers
{
    public class NextController : Controller
    {
        // GET: Next
        public ActionResult Index()
        {
            ViewBag.Message = "Loyalty Is The Most Important Key";
            return View();
        }
    }
}