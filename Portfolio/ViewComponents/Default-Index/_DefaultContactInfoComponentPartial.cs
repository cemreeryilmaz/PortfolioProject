using Microsoft.AspNetCore.Mvc;
using Portfolio.Data.Context;

namespace Portfolio.ViewComponents.Default_Index
{
    public class _DefaultContactInfoComponentPartial : ViewComponent
    {
        private readonly PortfolioContext _context;

        public _DefaultContactInfoComponentPartial(PortfolioContext context)
        {
            _context = context;
        }

        public IViewComponentResult Invoke()
        {
            var contactInfos = _context.ContactInfos.ToList();

            return View(contactInfos);
        }
    }
}