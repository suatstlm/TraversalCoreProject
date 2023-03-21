using Microsoft.AspNetCore.Mvc;

namespace Traversal.MVCUI.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
