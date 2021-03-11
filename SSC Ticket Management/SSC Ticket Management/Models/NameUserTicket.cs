using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSC_Ticket_Management.Models
{
    public class NameUserTicket
    {
        public Ticket Ticket { get; set; }

        public User User { get; set; }

    }
}