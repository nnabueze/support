using Support.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Support.Controllers
{
    public class SchoolController : Controller
    {
        support db = new support();
        // GET: School
        public ActionResult Index()
        {
            if (Session["isLogin"] != null)
            {
                return View();
            }

            return RedirectToAction("SchoolLogin", "Default");
        }

        [Route("school/payments")]
        public ActionResult payment()
        {
            if (Session["isLogin"] != null)
            {
                string AdmissionNo = Session["AdmissionNo"].ToString();
                string IGR_Code = Session["igr"].ToString();

                var info = db.student_information.Where(o => o.IGR_Code == IGR_Code && o.AdmissionNo == AdmissionNo).ToList();

                return View(info);
            }

            return RedirectToAction("SchoolLogin", "Default");
        }
    }
}