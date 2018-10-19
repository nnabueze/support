using Support.Models;
using System;
using System.Collections.Generic;
using System.IO;
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

        [Route("school/tickets")]
        public ActionResult Ticket()
        {
            IEnumerable<Ticket> ticketData = new List<Ticket>();

            string admissionNo = Session["AdmissionNo"].ToString();
            string IGR_Code = Session["igr"].ToString();

            if (Session["isLogin"] != null)
            {
                ticketData = db.Ticket.Where(o=>o.AdmissionNo == admissionNo && o.IGR_Code == IGR_Code).OrderByDescending(o => o.Created_at).ToList();

                return View(ticketData);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("school/tickets")]
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
            ticketParam.TicketId = RandomNumber() + RandomNumber();
            ticketParam.Id = ticketParam.TicketId;
            ticketParam.SourceData = requestPost.type;
            ticketParam.Ticket_Status = 1;
            ticketParam.IGR_Code = Session["igr"].ToString();
            ticketParam.Created_at = DateTime.Now;
            ticketParam.AdmissionNo = Session["AdmissionNo"].ToString();



            try
            {
                var ticketPara = db.Ticket.Add(ticketParam);
                db.SaveChanges();

                if (ticketPara != null)
                {
                    //EmailParam param = new EmailParam();
                    //param.Email = "nnabueze.opara@ercasng.com";
                    //param.From = "Open Ticket for IGR";
                    //EmailClass.sendEmail(EMAILAPI, param);
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
        [Route("school/CommentReply")]
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
                    try
                    {
                        commentModel.CommenterName = Session["name"].ToString();
                        commentModel.CommentMessage = commentreply;
                        commentModel.TicketId = ticketId;
                        commentModel.Created_at = DateTime.Now;
                        commentModel.CommentId = RandomNumber();

                        var commentData = db.Comment.Add(commentModel);
                        db.SaveChanges();

                        if (commentData != null)
                        {
                            //EmailParam param = new EmailParam();
                            //param.Email = "nnabueze.opara@ercasng.com";
                            //param.From = "Open Ticket for IGR";
                            //EmailClass.sendEmail(EMAILAPI, param);
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

        [Route("school/item")]
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
        [Route("school/item")]
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


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Route("school/payment")]
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
                invoiceData.AdmissionNo = Session["AdmissionNo"].ToString();
                invoiceData.IGR_Code = Session["igr"].ToString();
                invoiceData.Invoice_Status = "1";
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
                        info.AdmissionNo = Session["AdmissionNo"].ToString();
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


            // Generate a random number between two numbers
            public int RandomNumber()
        {
            var rnd = new Random(DateTime.Now.Millisecond);
            int rNum = DateTime.Now.Millisecond + rnd.Next(0, 9000000);
            return rNum;
        }
    }
}