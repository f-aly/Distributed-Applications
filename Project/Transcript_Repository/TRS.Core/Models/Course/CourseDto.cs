using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Core.Models.Course
{
    public class CourseDto
    {
        [Display(Name = "Course ID")]
        [Range(100000, 999999, ErrorMessage = "Course ID must be 6-digits long.")]
        [Required(ErrorMessage = "Please enter a valid Course ID.")]
        public int CourseId { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Please enter a valid Course Name.")]
        public string Name { get; set; }

        [Display(Name = "Course Qualification")]
        [Required(ErrorMessage = "Please enter a valid Course Qualification.")]
        public string Qualification { get; set; }

        [Display(Name = "Course Length")]
        [Range(00, 20, ErrorMessage = "Course Length must be no longer than 3-digits.\n and range from 0 to  20.")]
        [Required(ErrorMessage = "Please enter a valid Course Length.")]
        public int Length { get; set; }

    }
}
