using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APITest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApiController : ControllerBase
    {
        private readonly ILogger<ApiController> _logger;

        private List<Post> posts = new List<Post>()
        {
            new Post()
            {
                Title = "Hello World!",
                Content = "This is a sample post",
                Author = "Admin"
            },
            new Post()
            {
                Title = "Hello World!",
                Content = "This is a sample post",
                Author = "Admin"
            },
            new Post()
            {
                Title = "Hello World!",
                Content = "This is a sample post",
                Author = "Admin"
            }
        };

        private List<User> users = new List<User>()
        {
            new User()
            {
                Username = "Admin",
                Password = "admin"
            },

            new User()
            {
                Username = "Bob",
                Password = "bob"
            }
        };

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }

        [HttpGet("getposts")]
        public List<Post> GetPosts()
        {
            return posts;
        }

        [HttpGet("getposts/{title}")]
        public Post GetPosts(string title)
        {
            if (!string.IsNullOrWhiteSpace(title))
                return posts.Where(x => x.Title.ToLower() == title.ToLower()).FirstOrDefault();
            else
                GetPosts();

            return null;
        }

        [HttpGet("getusers")]
        public List<User> GetUsers()
        {
            return users;
        }

        [HttpGet("getusers/{username}")]
        public User GetUsers(string username)
        {
            if (!string.IsNullOrWhiteSpace(username))
                return users.Where(x => x.Username.ToLower() == username.ToLower()).FirstOrDefault();
            else
                GetUsers();

            return null;
        }
    }
}
