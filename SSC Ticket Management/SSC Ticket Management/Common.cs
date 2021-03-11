using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SSC_Ticket_Management.Models;


namespace SSC_Ticket_Management
{


    public class Common
    {


        static SSC_TicketEntities db = new SSC_TicketEntities();
        public Models.User DoLogin(string userName, string password,int userType)
        {
            Models.User userObj = db.User.Where(i => i.UserName == userName && i.Password == password && i.Type == userType).FirstOrDefault();
            return userObj;
        }


    }
}