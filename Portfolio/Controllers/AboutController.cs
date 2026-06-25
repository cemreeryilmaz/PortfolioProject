using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        private readonly PortfolioContext _context;

        public AboutController(PortfolioContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var about = _context.Abouts.FirstOrDefault();
            return View(about);
        }
    }
}
