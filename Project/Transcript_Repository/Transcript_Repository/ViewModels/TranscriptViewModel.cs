using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Transcript_Repository.DtoModels.Transcript;

namespace Transcript_Repository.ViewModels
{
    public class TranscriptViewModel
    {
        public List<TranscriptDto> Transcripts { get; set; }

        public TranscriptViewModel()
        {
            this.Transcripts = new List<TranscriptDto>();
        }
    }
}