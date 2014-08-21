using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models02.Models
{
    public class Comment
    {
        public Int32 CommentID { get; set; }

        public string Content { get; set; }

        public Int32 SessionID { get; set; }
        public virtual Session Session { get; set; }
    }
}