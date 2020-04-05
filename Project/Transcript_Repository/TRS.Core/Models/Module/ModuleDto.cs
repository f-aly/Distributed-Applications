using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Core.Models.Module
{
    public class ModuleDto
    {

        public int Id { get; set; }

        [Display(Name = "Module ID")]
        [Range(100000, 999999, ErrorMessage = "Module ID must be 6-digits long.")]
        [Required(ErrorMessage = "Please enter a valid Module ID.")]
        public int ModuleId { get; set; }

        [Display(Name = "Module Title")]
        [Required(ErrorMessage = "Please enter a valid Title.")]
        public string Title { get; set; }

        [Display(Name = "Module Trimester")]
        [Required(ErrorMessage = "Please enter a valid Module Trimester.")]
        public string Trimester { get; set; }

        [Display(Name = "Module Comment")]
        [Required(ErrorMessage = "Please enter a valid Module Comment.")]
        public string Comment { get; set; }
    }
}
