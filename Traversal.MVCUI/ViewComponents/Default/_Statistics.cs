using Microsoft.AspNetCore.Mvc;
using Traversal.DataAccesLayer.Concrete;

namespace Traversal.MVCUI.ViewComponents.Default
{
    public class _Statistics: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            using var c = new TraversalDBContext();
            ViewBag.v1 = c.Destinations.Count();
            ViewBag.v2 = c.Guides.Count();
            ViewBag.v3 = "285";
            return View();
        }
    }
}
