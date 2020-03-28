using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Transcript_Repository.Models
{
    public class ModuleModel
    {
        [Display(Name = "Module ID")]
        [Range(100000, 999999, ErrorMessage = "Module ID must be 6-digits long.")]
        [Required(ErrorMessage = "Please enter a valid Module ID.")]
        public int ModuleId { get; set; }

        [Display(Name = "Module Title")]
        [Required(ErrorMessage = "Please enter a valid Module Title.")]
        public string ModuleTitle { get; set; }

        [Display(Name = "Module Result")]
        [Range(000, 100, ErrorMessage = "Module Result must be no longer than 3-digits.\n and range from 0 to  100.")]
        [Required(ErrorMessage = "Please enter a valid Module Result.")]
        public int ModuleResult { get; set; }

        [Display(Name = "Module Trimester")]
        [Required(ErrorMessage = "Please enter a valid Module Trimester.")]
        public string ModuleTrimester { get; set; }

        [Display(Name = "Module Comment")]
        [Required(ErrorMessage = "Please enter a valid Module Comment.")]
        public string ModuleComment { get; set; }
    }
}