using Microsoft.VisualStudio.TestTools.UnitTesting;
using mukatalebackend.Controllers;
using mukatalebackend.Models;
using mukatalebackend.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mukatalebackend.Controllers.Tests
{
    [TestClass()]
    public class ValuesControllerTests
    {

        [TestMethod()]
        public void GetAll()
        {
            var NewPublicPost = new PublicPost
            {
                Title="Enyaanya",
                Description="Nuunji nyo",
                ImagePath = "path to file"
            };
            var post = new Post
            {
                Title = NewPublicPost.Title,
                Descritpion = NewPublicPost.Description,
                ImageFile = NewPublicPost.ImagePath,
                CreatedAt = DateTime.Now,
            };
           
            Assert.Fail();
        }
    }
}