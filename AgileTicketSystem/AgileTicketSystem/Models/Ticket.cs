using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileTicketSystem.Models
{
    //Properties for my Ticket class
    public class Ticket
    {
        public int TicketID { get; set; }

        public string TicketName { get; set; }

        public string TicketDesc { get; set; }

        public DateTime? Deadline { get; set; }

        public int PointValue { get; set; }
        public string SprintId { get; set; }
        public Sprint Sprint { get; set; }

        public string StatusId { get; set; }
        public Status Status { get; set; }

        public bool Overdue =>
            StatusId == "open" && Deadline < DateTime.Today;
    }
}