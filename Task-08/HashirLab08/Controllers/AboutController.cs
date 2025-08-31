using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HashirLab08.Controllers
{
    public class AboutController : Controller
    {
        
        public ActionResult Calculate(int num1, int num2, string operation)
        {
            double result = operation switch
            {
                "Add" => num1 + num2,
                "Subtract" => num1 - num2,
                "Multiply" => num1 * num2,
                "Divide" => num1 / num2,

                _ => 0
            };
            ViewData["Result"] = $"Result  : {result}";
            return View("About");
        }

        // GET: AboutController
        public ActionResult About()
        {
            return View();
        }

        // GET: AboutController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AboutController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AboutController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AboutController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AboutController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AboutController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AboutController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
