using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Transcript_Repository.DtoModels.Module
{
    public class ModuleDto
    {
        public int Module_ID { get; set; }
        public int ModuleGrade { get; set; }
        public int ACWGrade { get; set; }     
        public string Module_ACWs { get; set; }     

        public ModuleDto()
        {
            
        }
    }
}