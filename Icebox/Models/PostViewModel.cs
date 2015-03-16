using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Icebox.Models
{
    public class PostViewModel
    {
        [Key]
        public int PostID { get; set; }
        public Content PostContent { get; set; }
        public IList<string> Tags { get; set; }
    }
}