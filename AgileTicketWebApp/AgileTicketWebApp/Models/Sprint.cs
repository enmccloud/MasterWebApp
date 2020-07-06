using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgileTicketWebApp.Models
{
    //Properties of my ticket status class.
    public class Sprint
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public string AgileSprintID { get; set; }
        public string AgileSprintName { get; set; }
    }
}
