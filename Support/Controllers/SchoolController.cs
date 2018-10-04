using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Support.Controllers
{
    public class SchoolController : Controller
    {
        // GET: School
        public ActionResult Index()
        {
            if (Session["isLogin"] != null)
            {
                return View();
            }

            return RedirectToAction("SchoolLogin", "Default");
        }
    }
}