using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Support.Controllers
{
    public class DefaultController : Controller
    {
        support db = new support(); 

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

            try
            {
                var tinData = db.tins.Where(o => o.tin_no == tin || o.temporary_tin == tin).FirstOrDefault();
                
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message.ToString()+" | Please contact the Admin";
                return View("Index");
            }

            return View();
        }
    }
}