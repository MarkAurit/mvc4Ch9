using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models02.Controllers
{
    public class Photo
    {
        [DisplayName("Picture")]
        public byte[] PhotoFileBytes { get; set; }

        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        [DisplayName("Created Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yy")]
        public DateTime CreateDate { get; set; }
    }
}