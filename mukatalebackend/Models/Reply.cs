using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace mukatalebackend.Models
{
    public class Reply
    {
        public int Id { get; set; }
        public string ReplyText { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual Comment Comment { get; set; }
        
    }
}