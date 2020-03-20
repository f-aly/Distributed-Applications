using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
    public class TranscriptModel
    {
        public int Id { get; set; }
        public int TranscriptId { get; set; }
        public DateTime TranscriptDate { get; set; }
        public bool TranscriptStatus { get; set; }
    }
}
