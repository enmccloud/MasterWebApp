using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileTicketWebApp.Models
{
    //Creating my filters class with dictionary values for timeline of tickets.
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all";
            string[] filters = FilterString.Split('-');
            AgileSprintID = filters[0];
            Due = filters[1];
            AgileStatusID = filters[2];
        }

        public string FilterString { get; }
        public string AgileSprintID { get; }
        public string Due { get; }
        public string AgileStatusID { get; }

        public bool HasSprint => AgileSprintID.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";
        public bool HasStatus => AgileStatusID.ToLower() != "all";

        public static Dictionary<string, string> DueFilterValues =>
            new Dictionary<string, string>
            {
                {"future", "Future" },
                {"past", "Past" },
                {"today", "Today" }
            };
        public bool IsPast => Due.ToLower() == "past";
        public bool IsFuture => Due.ToLower() == "future";
        public bool IsToday => Due.ToLower() == "today";

    }
}
