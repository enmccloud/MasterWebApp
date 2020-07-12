using System;
using System.Collections.Generic;

namespace AgileTicketSystem.Models
{
    public partial class RedoStatuses
    {
        public RedoStatuses()
        {
            RedoTickets = new HashSet<RedoTickets>();
        }

        public string StatusId { get; set; }
        public string StatusName { get; set; }

        public virtual ICollection<RedoTickets> RedoTickets { get; set; }
    }
}
