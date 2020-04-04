using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRS.Core.Models.Course;

namespace TRS.Web.Models.Course
{
    public class ListViewModel
    {
        public List<CourseDto> Courses { get; set; }

        public ListViewModel()
        {
            Courses = new List<CourseDto>();
        }
    }
}