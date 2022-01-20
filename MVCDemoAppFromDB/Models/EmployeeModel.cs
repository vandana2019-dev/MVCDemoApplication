using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemoAppFromDB.Models
{

    // The below EmployeeModel is for Display Purpose in the form
    // The DB does not care about the below model
    public class EmployeeModel
    {
        [Display(Name ="Employee ID")]
        [Range(100000, 9999999, ErrorMessage = "You need to enter a valid EmployeeId")]
        public int EmployeeId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "You need to give us your first name")]
        public string  FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "You need to give us your last name")]
        public string LastName { get; set; }


        // Here, we have two EmailAddress as the User is going to Fill
        // EmployeeModel in the Class Library is not going to have ConfirmEmail  (two emails fields).
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        [Required(ErrorMessage = "You need to give us your EmailAddress")]
        public string EmailAddress { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("EmailAddress", ErrorMessage ="The Email and Confirm Email must match")]
        public string ConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="You must have a password")]
        [DataType(DataType.Password)]
        [StringLength(100, MinimumLength = 10, ErrorMessage ="You need to provide a long enough password")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Your password and confirm password do not match")]
        public string ConfirmPassword { get; set; }
    }
}