using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRS.Core.DomainModels
{
    public class Transcript
    {
        public int Id { get; set; }
        public int TranscriptId { get; set; }
        public DateTime TranscriptDate { get; set; }
        public bool TranscriptStatus { get; set; }
    }
}
