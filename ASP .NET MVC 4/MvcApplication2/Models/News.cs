using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class News
    {

        public int NewsId { get; set; }
        [StringLength(300)]
        [Required]
        public string Author { get; set; }
        [StringLength(200)]
        [Required]
        public string Title { get; set; }
        [DataType(DataType.MultilineText)]
        [Required]
        public string Content { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }

    public class Comment
    {
        public int CommentId { get; set; }
        public int NewsId { get; set; }
        public string Author { get; set; }
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        public virtual News News { get; set; }
    }
}