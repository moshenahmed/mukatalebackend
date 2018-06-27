using mukatalebackend.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using System.Web.Http;
using System.Web.Http.Cors;

namespace mukatalebackend.Controllers
{
    public class HomeController : Controller
    {
        [EnableCors(origins: "http://localhost:3000/", headers: "*", methods: "*")]
        public string Index()
        {
            ViewBag.Title = "Home Page";
            var post = new ValuesController();
            var PostList = JsonConvert.SerializeObject(post.Get());

            return PostList ;
        }
    }
}
