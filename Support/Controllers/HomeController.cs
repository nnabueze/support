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
        public const string EMAILAPI = "http://69.64.74.108:8011/api/pos/Sms";

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

            string tinNo = null;
            string tinParam = null;


            
            string biller = Session["igr"].ToString();

            try
            {
                if (Session["temporary_tin"] == null)
                {
                    tinNo = Session["tinNo"].ToString();
                    tinData = db.notification.Where(o => o.tin == tinNo && o.IGR_Code == biller).OrderByDescending(o => o.create_at).ToList();

                }
                else
                {
                    tinParam = Session["temporary_tin"].ToString();
                    tinData = db.notification.Where(o => o.tin == tinParam && o.IGR_Code == biller).OrderByDescending(o => o.create_at).ToList();
                }
                

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

            string tinNo = null;
            string tempararyTin = null;

            if (Session["isLogin"] != null)
            {
                if (Session["temporary_tin"] == null)
                {
                    tinNo = Session["tinNo"].ToString();
                    ticketData = db.Ticket.Where(o => o.TinId == tinNo).OrderByDescending(o => o.Created_at).ToList();
                }
                else
                {
                    tempararyTin = Session["temporary_tin"].ToString();
                    ticketData = db.Ticket.Where(o => o.TinId == tempararyTin).OrderByDescending(o => o.Created_at).ToList();
                }               

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
            string name = null;
            string email = null;
            string phone = null;

            ticketParam.Title = requestPost.Title;
            ticketParam.Message = requestPost.Message;
            ticketParam.TicketId = RandomNumber()+ RandomNumber();
            ticketParam.Id = ticketParam.TicketId;
            ticketParam.SourceData = requestPost.type;
            ticketParam.Ticket_Status = 1;
            ticketParam.IGR_Code = Session["igr"].ToString();
            ticketParam.Created_at = DateTime.Now;
            if (Session["temporary_tin"] == null)
            {
                ticketParam.TinId = Session["tinNo"].ToString();
                name = Session["name"].ToString();
                email = Session["email"].ToString();
                phone = Session["phone"].ToString();
            }
            else
            {
                ticketParam.TinId = Session["temporary_tin"].ToString();
                name = Session["name"].ToString();
                email = Session["email"].ToString();
                phone = Session["phone"].ToString();
            }

            

            try
            {
                var ticketPara = db.Ticket.Add(ticketParam);
                db.SaveChanges();

                if (ticketPara != null)
                {
                    EmailParam param = new EmailParam();
                    param.Email = "servicedelivery@ercasng.com";
                    param.SenderEmail = "no-reply@ercasng.com";
                    param.From = "Open Ticket for IGR";
                    param.Message = "Hi Admin,\n\nYou have a pending ticket with content below\n\nPlease login into support to respond ticket\n\n--------------\n\n"
                                    + requestPost.Message+ "\n\n------------\n\nSender Name: "+ name+ "\nTinNo: "+ ticketParam.TinId+
                                    "\nPhone: "+phone+ "\nEmaill: "+email;
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
                        var filePathOriginal = Server.MapPath("/Content/img");
                        var filePathThumbnail = Server.MapPath("/Content/img");
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

        [Route("igr/item")]
        public ActionResult PaymentItem()
        {
            if (Session["isLogin"] != null)
            {
                string igrCode = Session["igr"].ToString();
                IList<Models.subhead> listSubHeads = new List<Models.subhead>();
                IList<Models.revenuehead> listrevenuehead = new List<Models.revenuehead>();
                SchoolPaymentViewModel DataModel = new SchoolPaymentViewModel();

                try
                {
                    var mdaDatas = db.mdas.Where(o => o.IGR_ID == igrCode).ToList();
                    foreach (var item in mdaDatas)
                    {
                        var revHeads = db.revenueheads.Where(o => o.MDA_ID == item.MDA_ID).ToList();

                        foreach (var sub in revHeads)
                        {
                            listrevenuehead.Add(sub);
                            var subHead = db.subheads.Where(o => o.RevHead_ID == sub.ID).ToList();
                            foreach (var listSub in subHead)
                            {
                                listSubHeads.Add(listSub);
                            }

                        }
                    }

                    var mda = db.mdas.Where(o => o.IGR_ID == igrCode).FirstOrDefault();


                    DataModel.mdaData = mda.MDA_ID;
                    DataModel.subheads = listSubHeads;
                    DataModel.revenueheads = listrevenuehead;
                }
                catch (Exception ex)
                {
                    ViewBag.error = ex.Message.ToString() + "An error occured while loading Please contact the admin.. ";
                    return RedirectToAction("Index", "Error");
                }

                return View(DataModel);

            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("igr/payment")]
        public ActionResult paymentItemList(PaymentItemList paymentData)
        {

            if (Session["isLogin"] != null)
            {
                if (Convert.ToDecimal(paymentData.totalAmount) == 0)
                {
                    Session["PaymentItemList"] = "Total Amount can't be zero(0). Please select an item ";
                    return RedirectToAction("PaymentItem");
                }

                Models.invoice invoiceData = new Models.invoice();
                invoiceData.invoice_id = RandomNumber().ToString();
                invoiceData.name = Session["name"].ToString();
                if (string.IsNullOrEmpty(Session["tinNo"].ToString()))
                {
                    invoiceData.TinNo = Session["temporary_tin"].ToString();
                }
                else
                {
                    invoiceData.TinNo = Session["tinNo"].ToString();
                }
                
                invoiceData.IGR_Code = Session["igr"].ToString();
                invoiceData.amount = Convert.ToDecimal(paymentData.totalAmount);
                invoiceData.create_at = DateTime.Now;
                try
                {
                    db.invoices.Add(invoiceData);
                    db.SaveChanges();

                    foreach (var item in paymentData.items)
                    {
                        invoiceschoolitem info = new invoiceschoolitem();
                        info.invoice_id = invoiceData.invoice_id;
                        info.IGR_CODE = invoiceData.IGR_Code;
                        info.SubHead_ID = item;
                        if (string.IsNullOrEmpty(Session["tinNo"].ToString()))
                        {
                            info.TinNo = Session["temporary_tin"].ToString();
                        }
                        else
                        {
                            info.TinNo = Session["tinNo"].ToString();
                        }
                        info.Created_at = DateTime.Now;

                        db.invoiceschoolitem.Add(info);
                        db.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    Session["PaymentItemList"] = ex.Message.ToString() + " | Please contact Admin";
                    return RedirectToAction("PaymentItem");
                }

                Session["PaymentItemSuccessful"] = "Invoice generated successfully with ID " + invoiceData.invoice_id + " Total Amount " + invoiceData.amount;
                return RedirectToAction("PaymentItem");
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("igr/item")]
        public ActionResult PaymentItemRevenue(string head)
        {
            if (Session["isLogin"] != null)
            {
                string igrCode = Session["igr"].ToString();
                IList<Models.subhead> listSubHeads = new List<Models.subhead>();
                IList<Models.revenuehead> listrevenuehead = new List<Models.revenuehead>();
                SchoolPaymentViewModel DataModel = new SchoolPaymentViewModel();

                try
                {
                    if (head.Equals("All"))
                    {
                        var mdaDatas = db.mdas.Where(o => o.IGR_ID == igrCode).ToList();
                        foreach (var item in mdaDatas)
                        {
                            var revHeads = db.revenueheads.Where(o => o.MDA_ID == item.MDA_ID).ToList();

                            foreach (var sub in revHeads)
                            {
                                listrevenuehead.Add(sub);
                                var subHead = db.subheads.Where(o => o.RevHead_ID == sub.ID).ToList();
                                foreach (var listSub in subHead)
                                {
                                    listSubHeads.Add(listSub);
                                }

                            }
                        }
                    }
                    else
                    {
                        var mdaDatas = db.mdas.Where(o => o.IGR_ID == igrCode).ToList();
                        foreach (var item in mdaDatas)
                        {
                            var revHeads = db.revenueheads.Where(o => o.MDA_ID == item.MDA_ID).ToList();

                            foreach (var sub in revHeads)
                            {
                                listrevenuehead.Add(sub);

                            }
                        }

                        var subHead = db.subheads.Where(o => o.RevHead_ID == head).ToList();
                        foreach (var listSub in subHead)
                        {
                            listSubHeads.Add(listSub);
                        }
                    }

                    var mda = db.mdas.Where(o => o.IGR_ID == igrCode).FirstOrDefault();

                    DataModel.subheads = listSubHeads;
                    DataModel.revenueheads = listrevenuehead;
                    DataModel.mdaData = mda.MDA_ID;
                }
                catch (Exception ex)
                {
                    ViewBag.error = ex.Message.ToString() + "An error occured while loading Please contact the admin.. ";
                    return RedirectToAction("Index", "Error");
                }

                return View("PaymentItem", DataModel);

            }
            return RedirectToAction("Index");
        }

        [Route("igr/list-invoice")]
        public ActionResult invoice()
        {
            if (Session["isLogin"] != null)
            {
                string TinNo;
                if (Session["tinNo"] == null)
                {
                    TinNo = Session["temporary_tin"].ToString();
                }
                else
                {
                    TinNo = Session["tinNo"].ToString();
                }

                var info = db.invoices.Where(o => o.TinNo == TinNo).OrderByDescending(o => o.create_at).ToList();

                return View(info);
            }

            return RedirectToAction("SchoolLogin", "Default");
        }

        public ActionResult viewInvoice(string invoice, string tinNo)
        {
            if (Session["isLogin"] != null)
            {

                //var info = db.student_information.Where(o => o.IGR_Code == IGR_Code && o.AdmissionNo == AdmissionNo).ToList();
                var info = db.invoiceschoolitem.Where(o => o.invoice_id == invoice && o.TinNo == tinNo).OrderByDescending(o => o.Created_at).ToList();

                return View(info);
            }

            return RedirectToAction("SchoolLogin", "Default");
        }

        // Generate a random number between two numbers
        public int RandomNumber()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int rNum = DateTime.Now.Millisecond + rnd.Next(0, 90000);

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
        public ActionResult CommentReply(string commentreply, int ticketId)
        {
            if (Session["isLogin"] != null)
            {
                if (!string.IsNullOrEmpty(commentreply))
                {
                    TicketViewModel viewModel = new TicketViewModel();
                    viewModel.Comment = db.Comment.Where(o => o.TicketId == ticketId).ToList();
                    viewModel.ticket = db.Ticket.Where(o => o.TicketId == ticketId).FirstOrDefault();

                    Comment commentModel = new Comment();
                    string name = null;
                    string email = null;
                    string phone = null;
                    string tin = null;
                    try
                    {
                        commentModel.CommenterName = Session["name"].ToString();
                        commentModel.CommentMessage = commentreply;
                        commentModel.TicketId = ticketId;
                        commentModel.Created_at = DateTime.Now;
                        commentModel.CommentId = RandomNumber();

                        if (Session["temporary_tin"] == null)
                        {
                            tin = Session["tinNo"].ToString();
                            name = Session["name"].ToString();
                            email = Session["email"].ToString();
                            phone = Session["phone"].ToString();
                        }
                        else
                        {
                            tin = Session["temporary_tin"].ToString();
                            name = Session["name"].ToString();
                            email = Session["email"].ToString();
                            phone = Session["phone"].ToString();
                        }

                        var commentData = db.Comment.Add(commentModel);
                        db.SaveChanges();

                        if (commentData != null)
                        {
                            EmailParam param = new EmailParam();
                            param.Email = "servicedelivery@ercasng.com";
                            param.SenderEmail = "no-reply@ercasng.com";
                            param.From = "Open Ticket for IGR";
                            param.Message = "Hi Admin,\n\nYou have a pending ticket with content below\n\nPlease login into support to respond ticket\n\n--------------\n\n"
                                            + commentModel.CommentMessage + "\n\n------------\n\nSender Name: " + name + "\nTinNo: " + tin +
                                            "\nPhone: " + phone + "\nEmaill: " + email;
                            EmailClass.sendEmail(EMAILAPI, param);
                        }


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