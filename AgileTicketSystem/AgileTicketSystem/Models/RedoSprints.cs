using System;
using System.Collections.Generic;

namespace AgileTicketSystem.Models
{
    public partial class RedoSprints
    {
        public RedoSprints()
        {
            RedoTickets = new HashSet<RedoTickets>();
        }

        public string SprintId { get; set; }
        public string SprintName { get; set; }

        public virtual ICollection<RedoTickets> RedoTickets { get; set; }
    }
}
