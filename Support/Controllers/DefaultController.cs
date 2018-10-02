
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
            IEnumerable<Models.igr> biller = new List<Models.igr>();
            
            try
            {
                biller = db.igrs.Where(o => o.IsIGR == true).ToList();
            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message.ToString() + "An error occured while loading Please contact the admin.. ";
                return View();
            }

            return View(biller);
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

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("tin")]
        public ActionResult Tin(TinRequest requestParam)
        {
            IEnumerable<Models.igr> biller = new List<Models.igr>();
            biller = db.igrs.Where(o => o.IsIGR == true).ToList();
            Models.tin tinParam = new Models.tin();

            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
               .SelectMany(v => v.Errors)
               .Select(e => e.ErrorMessage));
                ViewBag.error = message;
                return View("Index", biller);
            }

            try
            {
                var checkBvn = db.tins.Where(o=>o.bvn == requestParam.bvn).FirstOrDefault();
                if (checkBvn != null)
                {
                    ViewBag.error = "Your Temporary tin: "+checkBvn.temporary_tin;
                    return View("Index", biller);
                }

               
                tinParam.bvn = requestParam.bvn;
                tinParam.name = requestParam.name;
                tinParam.email = requestParam.email;
                tinParam.phone = requestParam.phone;
                tinParam.address = requestParam.address;
                tinParam.IGR_Code = requestParam.biller;
                tinParam.temporary_tin = "TN" + RandomNumber();
                tinParam.tin_id = Guid.NewGuid().ToString();

                var tinData = db.tins.Add(tinParam);
                db.SaveChanges();

            }
            catch (Exception ex)
            {

                ViewBag.error = ex.Message.ToString()+" Please contact the admin.. ";
                return View("Index", biller);
            }


            ViewBag.UpdateInformation = "Successfull: Tin No " + tinParam.temporary_tin;
            return View("Index", biller);
        }

        public string RandomNumber()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            string rNum = DateTime.Now.Millisecond + rnd.Next(0, 900000000).ToString();

            return rNum;
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