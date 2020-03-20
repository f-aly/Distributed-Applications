using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Transcript_Repository.Models
{
    public class TranscriptModel
    {
        [Display(Name = "Transcript ID")]
        [Range(100000, 999999, ErrorMessage = "Transcript ID must be 6-digits long.")]
        [Required(ErrorMessage = "Please enter a valid Transcript ID.")]
        public int TranscriptId { get; set; }
        
        [Display(Name = "Transcript Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Required(ErrorMessage = "Please enter a valid Transcript Date.")]
        public DateTime TranscriptDate { get; set; }

        [Display(Name = "Transcript Status")]
        [Required(ErrorMessage = "Please enter a valid Transcript Status.")]
        public bool TranscriptStatus { get; set; }
    }
}