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

        [Route("IGR/login")]
        public ActionResult IGR()
        {
            return View();
        }

        [HttpPost]
        [Route("IGR/login")]
        public ActionResult login()
        {
            return View();
        }
    }
}