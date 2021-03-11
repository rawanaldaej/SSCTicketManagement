using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SSC_Ticket_Management.Models;


namespace SSC_Ticket_Management.Controllers
{
    public class AdminController : Controller
    {
        private SSC_TicketEntities db = new SSC_TicketEntities();

        // GET: Ticket
        

        public ActionResult Index()
        {
            if (Session["currentUser"] == "")
            {
                return RedirectToAction("AdminLogin", "Home");
            }
            //return View(db.Ticket.ToList());

            using (SSC_TicketEntities Tic = new SSC_TicketEntities())
            {
                List<Ticket> Ticket = Tic.Ticket.ToList();
                List<User> User = Tic.User.ToList();
                var UserTicket = from T in Ticket
                                 join U in User on T.CREATED_BY equals U.UserName into table1
                                 from U in table1.ToList()
                                 select new NameUserTicket
                                 {
                                     Ticket = T,
                                     User = U
                                 };
                return View(UserTicket.ToList());
            }

        }

        public ActionResult View()
        {
            if (Session["currentUser"] == "")
            {
                return RedirectToAction("AdminLogin", "Home");
            }
            //return View(db.Ticket.ToList());

            using (SSC_TicketEntities Tic = new SSC_TicketEntities())
            {
                List<Ticket> Ticket = Tic.Ticket_PerformCRUD("SELECT", null, null, null, null, null, null).ToList();

                return View(Ticket.ToList());
            }

        }

        // GET: Ticket/Details/
        public ActionResult Details(int? id)
        {
            if (Session["currentUser"] == "")
            {
                return RedirectToAction("AdminLogin", "Home");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket Ticket = db.Ticket.Find(id);
            if (Ticket == null)
            {
                return HttpNotFound();
            }
            return View(Ticket);
        }

        // GET: Ticket/Approve
        public ActionResult Approve(int? id)
        {
            if (Session["currentUser"] == "")
            {
                return RedirectToAction("AdminLogin", "Home");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket Ticket = db.Ticket.Find(id);
            if (Ticket == null)
            {
                return HttpNotFound();
            }
            return View(Ticket);
        }

        // POST: Ticket/Approve
        [HttpPost, ActionName("Approve")]
        [ValidateAntiForgeryToken]
        public ActionResult ApproveConfirmed(int ID)
        {

            if (Session["currentUser"] == "")
            {
                return RedirectToAction("AdminLogin", "Home");
            }
            
            using (SSC_TicketEntities Tic = new SSC_TicketEntities())
            {
                Tic.Ticket_PerformCRUD("UPDATEApprove", ID, null, null, null, null, null);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        // GET: Ticket/Reject
        public ActionResult Reject(int? id)
        {
            if (Session["currentUser"] == "")
            {
                return RedirectToAction("AdminLogin", "Home");
            }

            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ticket Ticket = db.Ticket.Find(id);
            if (Ticket == null)
            {
                return HttpNotFound();
            }
            return View(Ticket);
        }

        // POST: Ticket/Reject
        [HttpPost, ActionName("Reject")]
        [ValidateAntiForgeryToken]
        public ActionResult RejectConfirmed(int ID)
        {

            if (Session["currentUser"] == "")
            {
                return RedirectToAction("AdminLogin", "Home");
            }

            using (SSC_TicketEntities Tic = new SSC_TicketEntities())
            {
                Tic.Ticket_PerformCRUD("UPDATEReject", ID, null, null, null, null, null);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}