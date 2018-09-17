
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
                if (tinData != null)
                {
                    Session["isLogin"] = "yes";
                    Session["type"] = "IGR";
                    SetInfo(tinData);
                    return RedirectToAction("Index","Home");
                }

                ViewBag.error = "Invalid Tin No.";
                return View("Index");
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message.ToString()+" | Please contact the Admin";
                return View("Index");
            }
        }

        public bool SetInfo(Models.tin tinData)
        {
            Session["tinNo"] = tinData.tin_no;
            Session["name"] = tinData.name;
            Session["email"] = tinData.email;
            Session["address"] = tinData.address;
            Session["igr"] = tinData.IGR_Code;
            Session["temporary_tin"] = tinData.temporary_tin;
            Session["phone"] = tinData.phone;
            return true;
        }

        [Route("logout")]
        public ActionResult Logout()
        {
            if (Session["isLogin"] != null)
            {
                Session.RemoveAll();
                return RedirectToAction("Index","Default");
            }

            return RedirectToAction("Index", "Default");
        }
    }
}