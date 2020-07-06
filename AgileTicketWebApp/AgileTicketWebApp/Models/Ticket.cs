using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileTicketWebApp.Models
{
    //Properties for my ticket class. All data needed for the ticket.
    public class Ticket
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int AgileTicketID { get; set; }


        [Required(ErrorMessage = "Please enter a name for your ticket.")]
        public string AgileTicketName { get; set; }

        [Required(ErrorMessage = "Please enter a ticket description.")]
        public string AgileTicketDesc { get; set; }

        [Required(ErrorMessage = "Please Assign a Point Value.")]
        [Range(1, 5, ErrorMessage = "Value must be between 1 and 10.")]
        public int PointValue { get; set; }

        [Required(ErrorMessage = "Please enter a deadline for your ticket.")]
        public DateTime? Deadline { get; set; }

        [Required(ErrorMessage = "Please enter a sprint number for your ticket.")]
        public string AgileSprintID { get; set; }
        public Sprint Sprint { get; set; }

        [Required(ErrorMessage = "Please enter a status for your ticket.")]
        public string AgileStatusID { get; set; }
        public Status Status { get; set; }

        public bool Overdue =>
            AgileStatusID == "open" && Deadline < DateTime.Today;
    }
}
