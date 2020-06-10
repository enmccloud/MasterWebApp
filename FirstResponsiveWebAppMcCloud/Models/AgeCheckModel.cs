/***************************************************************
* Name        : 2020 Age Calculator Web App
* Author      : Nikki McCloud
* Created     : 05/30/2020
* Course      : CIS 174 – Advanced C#
* Version     : 1.0
* OS          : Windows 10
* Copyright   : This is my own original work based on            *               specifications issued by our instructor
* Description : This web application calculates age based on    *			 user’s birth date.  
*               Input: Name and Birth Date
*               Output: Age 
*			 
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or * * unmodified. I have not given other fellow student(s) access to * my program.         
***************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FirstResponsiveWebAppMcCloud.Models
{
    public class AgeCheckModel
    {   
        // Getting and setting user name- error message popluates if field is left blank.
        [Required(ErrorMessage = "Please enter your name.")]
        public string UserName { get; set; }

        // Getting and setting user birth date- error message popluates if date/time picker is left untouched.
        [Required(ErrorMessage = "Please enter or select a date.")]
        public DateTime BirthDate { get; set; }

        // Setting date to check birthdates against.
        public DateTime CheckDate = new DateTime(2020, 12, 31);

        // Method for figuring age. 
        public int AgeThisYear
        {
            get { return (CheckDate - BirthDate).Days / 365; }
        }

        public string NameEntered
        {
            get { return (UserName); }
        }

        public string TestAgeThisYear(string UserName) => throw new NotImplementedException();

        public static int CheckAgeThisYear(int expected) => throw new NotImplementedException();
    }
}
