using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Transcript_Repository.Models
{
    public class CourseModel
    {
        [Display(Name = "Course ID")]
        [Range(100000, 999999, ErrorMessage = "Course ID must be 6-digits long.")]
        [Required(ErrorMessage = "Please enter a valid Course ID.")]
        public int CourseId { get; set; }

        [Display(Name = "Course Name")]
        [Required(ErrorMessage = "Please enter a valid Course Name.")]
        public string CourseName { get; set; }

        [Display(Name = "Course Qualification")]
        [Required(ErrorMessage = "Please enter a valid Course Qualification.")]
        public string CourseQualification { get; set; }

        [Display(Name = "Course Result")]
        [Range(000, 100, ErrorMessage = "Course Result must be no longer than 3-digits.\n and range from 0 to  100.")]
        [Required(ErrorMessage = "Please enter a valid Course Result.")]
        public int CourseResult { get; set; }

        [Display(Name = "Course Length")]
        [Range(00, 20, ErrorMessage = "Course Length must be no longer than 3-digits.\n and range from 0 to  20.")]
        [Required(ErrorMessage = "Please enter a valid Course Length.")]
        public int CourseLength { get; set; }
    }
}