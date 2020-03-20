using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Transcript_Repository.Models
{
    public class OrganizationModel
    {
        [Display(Name = "Organization ID")]
        [Range(10000, 999999, ErrorMessage = "Organization ID must be 6-digits long.")]
        [Required(ErrorMessage = "Please enter a valid Organization ID.")]
        public int OrganizationId { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter a valid Organization Name.")]
        public string OrganizationName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter a valid Organization Email.")]
        [DataType(DataType.EmailAddress)]
        public string OrganizationEmail { get; set; }

        [Display(Name = "Confirm Email")]
        [Compare("OrganizationEmail", ErrorMessage = "This doesn't match your email.")]
        public string OrganizationConfirmEmail { get; set; }

        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Please enter a valid Organization Password.")]
        public string OrganizationPassword { get; set; }

        [Display(Name = "Confirm Password")]
        [DataType(DataType.Password)]
        [Compare("OrganizationPassword", ErrorMessage = "This doesn't match your password.")]
        public string OrganizationConfirmPassword { get; set; }
    }
}