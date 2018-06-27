using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mukatalebackend.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descritpion { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string ImageFile { get; set; }
        public ICollection<Comment> comment { get; set; }

    }
}