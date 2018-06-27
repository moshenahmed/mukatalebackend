using mukatalebackend.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace mukatalebackend
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base()
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Reply> Replies { get; set; }
    }
}