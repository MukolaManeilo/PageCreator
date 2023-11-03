using Microsoft.AspNetCore.Mvc;
using PageCreator.Data;
using PageCreator.Models;
using System.Text.Encodings.Web;

namespace PageCreator.Controllers
{
    public class HomeController : Controller
    {
        private readonly PageCreatorContext _context;

        public HomeController(PageCreatorContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Pages> pages = _context.Pages.ToList();
            return View(pages);
        }
    }
}
