using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transcript_Repository.DtoModels.CourseContent;

namespace Transcript_Repository.DtoModels.EnrolledCourses
{
    public class EnrolledCourseDto
    {
        public int Enrolled_course_ID { get; set; }
        public int Module_ID { get; set; }
        public int Semester_ID { get; set; }

        public EnrolledCourseDto()
        {
            //Semester_ID = Semester_ID_;
            //Enrolled_course_ID = Enrolled_course_ID_;
            //Module_ID = Module_ID_;
            CourseContentDto course_content = new CourseContentDto
            {
                EnrolledCOurseID = Enrolled_course_ID,
                SemesterID = Semester_ID,
                ModuleID = Module_ID
            };
        }
    }
}