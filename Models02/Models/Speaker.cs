using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models02.Models
{
    public class Speaker
    {
        public Int32 SpeakerID { get; set; }

        [Required(ErrorMessage = "{0} is required")]
        [Display(Name = "Speaker")]
        public string Name { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        public virtual List<Session> Sessions { get; set; }
    }
}