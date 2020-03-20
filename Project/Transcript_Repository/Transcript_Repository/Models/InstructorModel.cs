using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Transcript_Repository.Models
{
    public class InstructorModel
    {
        [Display(Name = "Instructor ID")]
        [Range(10000, 999999, ErrorMessage = "Instructor ID must be 6-digits long.")]
        [Required(ErrorMessage = "Please enter a valid Instructor ID.")]
        public int InstructorId { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "Please enter a valid Instructor First Name.")]
        public string InstructorFirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Please enter a valid Instructor Last Name.")]
        public string InstructorLastName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter a valid Instructor Email.")]
        [DataType(DataType.EmailAddress)]
        public string InstructorEmail { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("InstructorEmail", ErrorMessage = "This doesn't match your email.")]
        public string InstructorConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a valid Instructor Password.")]
        public string InstructorPassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("InstructorPassword", ErrorMessage = "This doesn't match your password.")]
        public string InstructorConfirmPassword { get; set; }
    }
}