using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Support.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("IGR/login")]
        public ActionResult login(string tin)
        {
            if (string.IsNullOrEmpty(tin))
            {
                ViewBag.error = "Tin is required";
                return View("Index");

            }
            return View();
        }
    }
}