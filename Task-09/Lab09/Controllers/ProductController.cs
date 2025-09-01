using Lab09.Models;
using Lab09.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Lab09.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDBContext db;

        public ProductController(ApplicationDBContext applicationDBContext)
        {
            db = applicationDBContext;
        }
        public IActionResult Index()
        {
            var product = db.Products.ToList();
            return View(product);
        }

        public ActionResult Create(AddProduct addProduct)
        {
            try
            {
                Product product = new Product()
                {
                    Name = addProduct.Name,
                    Description = addProduct.Description,
                    price = addProduct.price
                };

                db.Products.Add(product);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Delete(Product product)
        {
            try
            {
                var dbProduct = db.Products.SingleOrDefault(p => p.id == product.id);
                db.Products.Remove(dbProduct);
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public ActionResult Edit(Product product)
        {
            try
            {
                var dbProduct = db.Products.SingleOrDefault(p => p.id == product.id);
                dbProduct.Name = product.Name;
                dbProduct.Description = product.Description;
                dbProduct.price = product.price;
                db.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
