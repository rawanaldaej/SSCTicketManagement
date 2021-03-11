using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SSC_Ticket_Management.Models;

namespace SSC_Ticket_Management.Controllers
{
    public class HomeController : Controller
    {
        SSC_TicketEntities DB = new SSC_TicketEntities();      
        Common commonObj = new Common();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult AdminLogin()
        {
            ViewBag.error = "";
            return View();
        }

        [HttpPost]
        public ActionResult AdminLogin(string userName, string password)
        {
            Models.User userObj = commonObj.DoLogin(userName, password, 1);
            if (userObj == null)
            {
                ViewBag.error = "Worng User Name/Password";
                return View();
            }
            else
            {
                Session["currentUser"] = userObj;
            }


            return RedirectToAction("Index", "Admin");
        }




        public ActionResult EmployeeLogin()
        {
            ViewBag.error = "";
            return View();
        }


        [HttpPost]
        public ActionResult EmployeeLogin(string userName, string password)
        {
            Models.User userObj = commonObj.DoLogin(userName, password, 2);
            if (userObj == null)
            {

                ViewBag.error = "Worng User Name/Password";
                return View();
            }
            else
            {
                Session["currentUser"] = userObj;
            }

            return RedirectToAction("Index", "Employee");
        }


        public ActionResult SignOut()
        {
            SSC_Ticket_Management.Models.User userObj = (SSC_Ticket_Management.Models.User)Session["currentUser"];

            int type = userObj.Type;

            Session["currentUser"] = "";


            if (type == 1)
            {
                return RedirectToAction("AdminLogin", "Home");
            }
            return RedirectToAction("EmployeeLogin", "Home");
        }



    }


}