using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;
using MyPortfolioUdemy.DAL.Entities;

namespace MyPortfolioUdemy.Controllers
{
    public class ReferenceController : Controller
    {
        MyPortfolioContext context = new MyPortfolioContext();
        public IActionResult ReferenceList()
        {
            var values = context.References.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateReference()
        {
            return View();

        }
        [HttpPost]
        public IActionResult CreateReference(Reference reference)
        {

            context.References.Add(reference);
            context.SaveChanges();
            return RedirectToAction("ReferenceList");
        }
        public IActionResult DeleteReference(int id)
        {
            var value = context.References.Find(id);
            context.References.Remove(value);
            context.SaveChanges();
            return RedirectToAction("ReferenceList");
        }
        [HttpGet]
        public IActionResult UpdateReference(int id)
        {
            var value = context.References.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateReference(Reference reference)
        {
            context.References.Update(reference);
            context.SaveChanges();
            return RedirectToAction("ReferenceList");
        }
    }
}
