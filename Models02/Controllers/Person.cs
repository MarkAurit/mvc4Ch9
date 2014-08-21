using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models02.Controllers
{
    public class Person
    {
        public int PersonID { get; set; }

        [Range(0,400)]
        public int Height { get; set; }

        [Required (ErrorMessage = "Please enter an email address")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }
    }
}