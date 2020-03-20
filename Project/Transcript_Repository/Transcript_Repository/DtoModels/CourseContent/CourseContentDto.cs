using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transcript_Repository.DtoModels.Module;

namespace Transcript_Repository.DtoModels.CourseContent
{
    public class CourseContentDto
    {
        public int EnrolledCOurseID { get; set; }
        public int SemesterID { get; set; }
        public int ModuleID { get; set; }

        public CourseContentDto()
        {
            ModuleDto module = new ModuleDto
            {
                ACWGrade = 5,
                ModuleGrade = 60,
                Module_ACWs = "One",
                Module_ID= 700098
            };
        }
    }
}