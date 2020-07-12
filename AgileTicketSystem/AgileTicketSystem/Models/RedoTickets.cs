using System;
using System.Collections.Generic;

namespace AgileTicketSystem.Models
{
    public partial class RedoTickets
    {
        public int TicketId { get; set; }
        public string TicketName { get; set; }
        public string TicketDesc { get; set; }
        public DateTime? Deadline { get; set; }
        public int PointValue { get; set; }
        public string SprintId { get; set; }
        public string StatusId { get; set; }

        public virtual RedoSprints Sprint { get; set; }
        public virtual RedoStatuses Status { get; set; }
    }
}
