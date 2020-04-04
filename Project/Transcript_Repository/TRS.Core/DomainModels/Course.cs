﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Core.DomainModels
{
    public class Course
    {
        public int Id { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseQualification { get; set; }
        public int CourseResult { get; set; }
        public int CourseLength { get; set; }
    }
}
