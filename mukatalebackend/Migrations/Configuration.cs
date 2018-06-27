namespace mukatalebackend.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<mukatalebackend.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(mukatalebackend.ApplicationDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

            context.Posts.AddOrUpdate(
                new Models.Post {
                    Title = "This is test one",
                    Descritpion = "this is desciption test one",
                    CreatedAt=DateTime.Now,
                    UpdatedAt= DateTime.Now
                },
                    new Models.Post
                      {
                     Title = "This is test two",
                     Descritpion = "this is desciption test two",
                     CreatedAt = DateTime.Now.AddDays(-5),
                     UpdatedAt = DateTime.Now.AddDays(-5)
                    },
                       new Models.Post
                       {
                           Title = "This is test three",
                           Descritpion = "this is desciption test three",
                           CreatedAt = DateTime.Now.AddDays(-65),
                           UpdatedAt = DateTime.Now.AddDays(-65)
                       }
                );

            context.SaveChanges();
        }
    }
}
