using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Support.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            if (Session["isLogin"] != null)
            {
                Console.WriteLine(Session["tinNo"] + " "+ Session["temporary_tin"]);
                return View();
            }

            return RedirectToAction("Index","Default");
        }
    }
}