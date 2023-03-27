using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccesLayer.EntityFramework;
using Traversal.EntityLayer.Concrete;

namespace Traversal.MVCUI.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager _destinationManager = new(new EfDestinationDal());

        public IActionResult Index()
        {
            var result = _destinationManager.TGetAll();
            return View(result);
        }

        [HttpGet]
        public IActionResult DestinationDetails(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult DestinationDetails(Destination destination)
        {
            return View();
        }
    }
}
