using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models02.Models
{
    public class Session
    {
        public Int32 SessionID { get; set; }

        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Abstract   { get; set; }

        public Int32 SpeakerID { get; set; }

        public virtual Speaker Speaker { get; set; }

        public virtual List<Comment> Comments { get; set; }
    }
}