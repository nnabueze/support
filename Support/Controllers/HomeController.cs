using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Support.Controllers
{
    public class HomeController : Controller
    {
        support db = new support();

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

        [Route("payments")]
        public ActionResult Payments()
        {
            IEnumerable<Models.notification> tinData = new List<Models.notification>();

            if (Session["isLogin"] == null)
            {
                return RedirectToAction("Index", "Default");
            }

            string tinNo = Session["tinNo"].ToString();
            string tinParam = Session["temporary_tin"].ToString();
            string biller = Session["igr"].ToString();

            try
            {
                tinData = db.notifications.Where(o => o.tin ==  tinNo || o.tin == tinParam && o.IGR_Code == biller).OrderByDescending(o=>o.create_at).ToList();

            }
            catch (Exception ex)
            {
                ViewBag.error = ex.Message.ToString() + " | Please contact the Admin";
                return View();
            }

            return View(tinData);
        }

        [Route("tickets")]
        public ActionResult Ticket()
        {
            IEnumerable<Models.Ticket> ticketData = new List<Models.Ticket>();

            string tinNo = Session["tinNo"].ToString();
            string tempararyTin = Session["temporary_tin"].ToString();

            if (Session["isLogin"] != null)
            {
                ticketData = db.Ticket.ToList();

                return View(ticketData);
            }
            return RedirectToAction("Index");
        }

        public ActionResult Ticket_Reply()
        {
            if (Session["isLogin"] != null)
            {

                return View();
            }
            return RedirectToAction("Index");
        }
    }
}