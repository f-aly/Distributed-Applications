using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transcript_Repository.DtoModels.EnrolledCourses;

namespace Transcript_Repository.DtoModels.TranscriptContent
{
    public class TranscriptcontentDto
    {
        public int TranscriptID { get; set; }
        public int Enrolled_Course_ID { get; set; }

        public TranscriptcontentDto( )
        {
            //Enrolled_Course_ID = Enrolled_Course_ID_;
            //TranscriptID = TranscriptID_;
            EnrolledCourseDto EnrolledCoures_ = new EnrolledCourseDto
            {
                Enrolled_course_ID = Enrolled_Course_ID,
                Module_ID = 2,
                Semester_ID = 1
            };

        }
    }
}