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
    public class EmployeeController : Controller
    {
        private SSC_TicketEntities db = new SSC_TicketEntities();
 
        // GET: Employee
        public ActionResult Index()
        {
            

            if (Session["currentUser"] == "")
            {
                return RedirectToAction("EmployeeLogin", "Home");
            }
            SSC_Ticket_Management.Models.User userObj = (SSC_Ticket_Management.Models.User)Session["currentUser"];
            Session["currentUser"] = userObj;
            string currentuser = userObj.UserName;
            using (SSC_TicketEntities Tic = new SSC_TicketEntities())
            {
                List<Ticket> Ticket = Tic.Ticket_PerformCRUD("SELECTEmployee", null, null, null, null, currentuser, null).ToList();

                return View(Ticket.ToList());
            }

        }

        // GET: Ticket/Create
        public ActionResult Create()
        {
            if (Session["currentUser"] == "")
            {
                return RedirectToAction("EmployeeLogin", "Home");
            }
            
            ViewBag.Ticket = new SelectList(db.Ticket, "Title", "Description");
            return View();
        }

        // POST: Ticket/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Ticket Ticket)
        {
            if (Session["currentUser"] == "")
            {
                return RedirectToAction("EmployeeLogin", "Home");
            }

                SSC_Ticket_Management.Models.User userObj = (SSC_Ticket_Management.Models.User)Session["currentUser"];
                Session["currentUser"] = userObj;
                string currentuser = userObj.UserName;
            if (ModelState.IsValid)
            {
                using (SSC_TicketEntities Tic = new SSC_TicketEntities())
                {
                    Ticket Tick = Tic.Ticket_PerformCRUD("INSERT", null, Ticket.Ticket_Title, Ticket.Ticket_Description, null, currentuser, null).FirstOrDefault();
                    Tic.SaveChanges();
                }

                return RedirectToAction("Index");
            }

            return View(Ticket);

        }
    }
}