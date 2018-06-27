using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mukatalebackend.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string CommentText { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual Post Post { get; set; }

        public ICollection<Reply> Reply { get; set; }
    }
}