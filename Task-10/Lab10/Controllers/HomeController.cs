using Lab10.Models;
using Lab10.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Text.Json.Nodes;

namespace Lab10.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext _db)
        {
            db = _db;
        }



        public async Task<IActionResult> Index()
        {
            var posts = await GetPostFromApi();

            //Save to database
            db.Posts.AddRange(posts);
            db.SaveChanges();
            return View(posts);
        }
        private async Task<List<Post>> GetPostFromApi()
        {
            string apiUrl = "https://jsonplaceholder.typicode.com/posts";
            using (HttpClient client = new HttpClient())
            {
                string jsonresponse = await client.GetStringAsync(apiUrl);

                var postArray = JArray.Parse(jsonresponse);
                var posts = postArray.Select(post=>new Post
                { 
                    //Id = (int)post["id"],
                    UserId = (int)post["userId"],
                    Title = (string)post["title"],
                    Body = (string)post["body"]
                }).ToList();

                return posts;

            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
