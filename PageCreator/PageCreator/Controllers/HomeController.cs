using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace PageCreator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
