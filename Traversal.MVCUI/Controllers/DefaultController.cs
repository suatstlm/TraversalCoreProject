using Microsoft.AspNetCore.Mvc;

namespace Traversal.MVCUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
