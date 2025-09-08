using System.Diagnostics;
using Lab11.Models;
using Lab11.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lab11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext db;

        public HomeController(ApplicationDbContext _db)
        {
            db = _db;
        }

        public IActionResult GetAll()
        {
            return Ok(db.Products.ToList());
        }

        [HttpGet("{id}")]

        public IActionResult Get(int id)
        {
            var Product = db.Products.Find(id);

            return Product == null ? NotFound() : Ok(Product);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }
        [HttpPut("{id}")]

        public IActionResult Put(int id, [FromBody] Product updates)
        {
            var product = db.Products.Find(id);
            if (product == null) return NotFound();
            product.name = updates.name;
            product.Description = updates.Description;
            product.Price = updates.Price;
            db.SaveChanges();
            return Ok(product);
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            var product = db.Products.Find(id);
            if (product == null) return NotFound();
            db.Products.Remove(product);
            db.SaveChanges();

            return NoContent();
        }




    }
}
