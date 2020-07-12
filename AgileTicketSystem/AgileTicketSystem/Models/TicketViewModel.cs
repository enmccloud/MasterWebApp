using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileTicketSystem.Models
{
    //Creating view model for binding
    public class TicketViewModel
    {
        public TicketViewModel()
        {
            CurrentTask = new Ticket();
        }
        public Filters Filters { get; set; }
        public List<Status> Redo_Statuses { get; set; }
        public List<Sprint> Redo_Sprints { get; set; }

        public Dictionary<string, string> DueFilters { get; set; }

        public List<Ticket> Tasks { get; set; }

        public Ticket CurrentTask { get; set; }
    }
}
