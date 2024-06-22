using Microsoft.AspNetCore.Mvc;
using MyPortfolioUdemy.DAL.Context;

namespace MyPortfolioUdemy.Controllers
{
    public class StatisticAdminController : Controller
    {
		MyPortfolioContext context = new MyPortfolioContext();
		public IActionResult StatisticIndex()
        {
			ViewBag.v1 = context.Skills.Count();
			ViewBag.v2 = context.Experiences.Count();
			ViewBag.v3 = context.Certificates.Count();
			ViewBag.v4 = context.References.Count();

			return View();
        }
    }
}
