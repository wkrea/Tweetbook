
using kreaCore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Tweetbook.Contracts.V1;

namespace Tweetbook.Controllers.V1
{
    public class PublicacionesController : Controller
    {
        private List<Post> _posts;

        public PublicacionesController()
        {
            _posts = new List<Post>();

            for (int i = 0; i < 5; i++)
            {
                _posts.Add(new Post { Id = Guid.NewGuid().ToString() });
            }
        }

        [HttpGet]
        [Route(ApiRoutes.Posts.GetAll)]
        public IActionResult GetAll() => Ok(_posts);
    }
}
