using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HomePageMcCloud.Models.Student
{
    public class Student
    {
        // Get/Set for First Name Property with validation
        [Required]
        [StringLength(25)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        // Get/Set for Last Name Property with validation
        [Required]
        [StringLength(25)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        // Get/Set for Grade Property with validation
        [Required]
        [Range(1, 100)]
        public int Grade { get; set; }

    }
}
