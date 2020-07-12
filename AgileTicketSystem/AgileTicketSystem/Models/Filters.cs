using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgileTicketSystem.Models
{
    //Properties for my filter class
    public class Filters
    {
        public Filters(string filterstring)
        {
            FilterString = filterstring ?? "all-all-all";
            string[] filters = FilterString.Split('-');
            SprintID = filters[0];
            Due = filters[1];
            StatusID = filters[2];
        }

        public string FilterString { get; }
        public string SprintID { get; }
        public string Due { get; }
        public string StatusID { get; }

        public bool HasSprint => SprintID.ToLower() != "all";
        public bool HasDue => Due.ToLower() != "all";
        public bool HasStatus => StatusID.ToLower() != "all";

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
