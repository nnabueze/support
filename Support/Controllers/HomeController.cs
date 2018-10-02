using Support.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Support.Controllers
{
    public class HomeController : Controller
    {
        support db = new support();
        public const string EMAILAPI = "http://hub.ercasng.com:8011/api/pos/Sms";

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
            IEnumerable<Ticket> ticketData = new List<Ticket>();

            string tinNo = Session["tinNo"].ToString();
            string tempararyTin = Session["temporary_tin"].ToString();

            if (Session["isLogin"] != null)
            {
                ticketData = db.Ticket.Where(o => o.TinId == tinNo || o.TinId == tempararyTin).OrderByDescending(o => o.Created_at).ToList();

                return View(ticketData);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("tickets")]
        public ActionResult CreateTicket(HttpPostedFileBase file, TicketPost requestPost)
        {
            if (!ModelState.IsValid)
            {
                var message = string.Join(" | ", ModelState.Values
               .SelectMany(v => v.Errors)
               .Select(e => e.ErrorMessage));
                Session["Error"] = message;
                return RedirectToAction("Ticket");
            }

            //save  ticket
            Ticket ticketParam = new Ticket();
            ticketParam.Title = requestPost.Title;
            ticketParam.Message = requestPost.Message;
            ticketParam.TicketId = RandomNumber()+ RandomNumber();
            ticketParam.SourceData = requestPost.type;
            ticketParam.Ticket_Status = 1;
            ticketParam.Created_at = DateTime.Now;
            if (Session["temporary_tin"] == null)
            {
                ticketParam.TinId = Session["tinNo"].ToString();
            }
            else
            {
                ticketParam.TinId = Session["temporary_tin"].ToString();
            }

            try
            {
                var ticketPara = db.Ticket.Add(ticketParam);
                db.SaveChanges();
                if (ticketPara != null)
                {
                    EmailParam param = new EmailParam();
                    param.Email = "nnabueze.opara@ercasng.com";
                    param.From = "Open Ticket for IGR";
                    EmailClass.sendEmail(EMAILAPI, param);
                }
            }
            catch (Exception ex)
            {
                Session["Error"] = ex.Message.ToString();
                return RedirectToAction("Ticket");
            }
            

            foreach (string upload in Request.Files)
            {
                if (Request.Files[upload].ContentLength > 0)
                {
                    var filename = ticketParam.TicketId + ".png";
                    var size = Request.Files[upload].ContentLength;

                    if (size > 532000)
                    {
                        Session["Error"] = "File cannot be larger than 500KB";
                        return RedirectToAction("Ticket");

                    }
                    var FileExt = Request.Files[upload].ContentType;
                    if (FileExt == "image/png" || FileExt == "image/jpeg")
                    {
                        var filePathOriginal = Server.MapPath("/Content/ticket");
                        var filePathThumbnail = Server.MapPath("/Content/ticket");
                        string savedFileName = Path.Combine(filePathOriginal, filename);
                        Request.Files[upload].SaveAs(savedFileName);
                    }
                    else
                    {
                        Session["Error"] = "Please upload a .png or .jpeg format";
                        return RedirectToAction("Ticket");
                    }
                }
            }

            Session["Sucess"] = "Ticket successfully opened";
            return RedirectToAction("Ticket");
        }

        // Generate a random number between two numbers
        public long RandomNumber()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            long rNum = DateTime.Now.Millisecond + rnd.Next(0, 900000000);

            return rNum;
        }
        
        public ActionResult Ticket_Reply(long id)
        {
            if (Session["isLogin"] != null)
            {
                TicketViewModel viewModel = new TicketViewModel();
                viewModel.Comment = db.Comment.Where(o => o.TicketId == id).ToList();
                viewModel.ticket = db.Ticket.Where(o => o.TicketId == id).FirstOrDefault();
                return View(viewModel);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("CommentReply")]
        public ActionResult CommentReply(string commentreply, long ticketId)
        {
            if (Session["isLogin"] != null)
            {
                if (!string.IsNullOrEmpty(commentreply))
                {
                    TicketViewModel viewModel = new TicketViewModel();
                    viewModel.Comment = db.Comment.Where(o => o.TicketId == ticketId).ToList();
                    viewModel.ticket = db.Ticket.Where(o => o.TicketId == ticketId).FirstOrDefault();

                    Comment commentModel = new Comment();
                    try
                    {
                        commentModel.CommenterName = Session["name"].ToString();
                        commentModel.CommentMessage = commentreply;
                        commentModel.TicketId = ticketId;
                        commentModel.Created_at = DateTime.Now;
                        commentModel.CommentId = RandomNumber();

                        var commentData = db.Comment.Add(commentModel);
                        db.SaveChanges();


                    }
                    catch (Exception ex)
                    {
                        ViewBag.Error = "Unable to add comment";
                    }
                    return View("Ticket_Reply", viewModel);
                }
            }
            return RedirectToAction("Index");
        }
    }
}