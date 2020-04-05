using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TRS.Core.Models.Transcript;

namespace TRS.Web.Models.Transcript
{
    public class ListViewModel
    {
        public List<TranscriptDto> Transcripts { get; set; }

        public ListViewModel()
        {
            Transcripts = new List<TranscriptDto>();
        }
    }
}