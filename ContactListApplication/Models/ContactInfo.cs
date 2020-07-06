/***************************************************************
* Name        : Contact List Web Application	
* Author      : Nikki McCloud
* Created     : 06/02/2020
* Course      : CIS 169 - C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : Allows a user to catalog, add, remove, edit contacts.
*               Input: Name, Phone Number, Address, City, State, Zip, and Note (optional).
*               Output: Catalog list of all contacts.
*			 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactListApplication.Models
{
    public class ContactInfo
    {
        // All my properties for the Contact Info Class.
        // I had issues with the database recoginizing ContactId as the Primary key and found this work around.
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a Name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter a 9 Digit Telephone Number.")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter a Street Address.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Please enter a City.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter the State Abbreviation.")]
        public string StateAbbr { get; set; }

        [Required(ErrorMessage = "Please enter a Zip Code.")]
        [Range(00000, 99999, ErrorMessage = "Zip Code must be 5 digits.")]
        public int? ZipCode { get; set; }

        public string Note { get; set; }

    }
}
