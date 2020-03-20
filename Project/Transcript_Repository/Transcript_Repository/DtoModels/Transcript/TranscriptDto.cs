using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transcript_Repository.DtoModels.Module;
using Transcript_Repository.DtoModels.TranscriptContent;
using Transcript_Repository.DtoModels.CourseContent;

namespace Transcript_Repository.DtoModels.Transcript
{
    public class TranscriptDto
    {      
        public int SemesterID { get; set; }
        public int EnrolledCourseID { get; set; }
        public List<ModuleDto> Modules_Taken { get; set; }
        public int Transcript_ID { get; set; }
        
    }
}