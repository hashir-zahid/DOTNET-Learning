using HashirLab08.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HashirLab08.Controllers
{
    public class ContactController : Controller
    {
        // GET: ContactController
        public ActionResult Contact()
        {
            ViewData["countries"] = new List<string>
            {
                "ABC","PAK ","US","SA"
            };
            return View();
        }

        public ActionResult Signup(SignupModel model)
        {
            ViewData["Message"] = $"Thank You , {model.FullName}! signedup from {model.Country}.";
            ViewData["countries"] = new List<string>
            {
                "ABC","PAK ","US","SA"
            };
            return View("Contact");
        }

        // GET: ContactController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ContactController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactController/Create
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

        // GET: ContactController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ContactController/Edit/5
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

        // GET: ContactController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ContactController/Delete/5
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
