using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AgileTicketSystem.Models
{
    //Properties for my Ticket class
    //Added requirements (data validations) for all inputs.
    public class Ticket
    {
        public int TicketID { get; set; }

        [Required(ErrorMessage = "Please enter a name for your Ticket.")]
        public string TicketName { get; set; }

        [Required(ErrorMessage = "Please enter a description of the ticket.")]
        public string TicketDesc { get; set; }

        [Required(ErrorMessage = "Please enter a deadline date.")]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:MM/dd/yyy}", ApplyFormatInEditMode = true)]
        public DateTime? Deadline { get; set; }

        [Required(ErrorMessage = "Please enter a point value for the ticket.")]
        [Range(1, 9, ErrorMessage = "The point value must be between 1 and 9")]
        public int PointValue { get; set; }

        [Required(ErrorMessage = "Please select a Sprint ID")]
        public string SprintId { get; set; }
        public Sprint Sprint { get; set; }

        [Required(ErrorMessage = "Please select a Status ID")]
        public string StatusId { get; set; }
        public Status Status { get; set; }

        public bool Overdue =>
            StatusId == "open" && Deadline < DateTime.Today;
    }
}