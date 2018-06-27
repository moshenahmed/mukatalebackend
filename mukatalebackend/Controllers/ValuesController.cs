using mukatalebackend.Models;
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
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
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
