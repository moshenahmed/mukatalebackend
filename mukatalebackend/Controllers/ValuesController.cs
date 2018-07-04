using mukatalebackend.Models;
using mukatalebackend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace mukatalebackend.Controllers
{
    
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET api/values
        public  IEnumerable<Post> Get()
        {
            var posts = context.Posts.ToList();
            return posts;
        }

        // GET api/values/5
        public Post Get(int? id)
        {
            var post = context.Posts.Find(id);
            return post;
        }

        // POST api/values
        public HttpResponseMessage Post(PublicPost post)
        {
            var NewPost = new Post
            {
                Title=post.Title,
                Descritpion=post.Description,
                ImageFile=post.ImagePath,
                CreatedAt=DateTime.Now
            };
            context.Posts.Add(NewPost);
            context.SaveChanges();
            var createdPost = Get(NewPost.Id);

        
            return Request.CreateResponse<Post>(HttpStatusCode.Created, createdPost);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
