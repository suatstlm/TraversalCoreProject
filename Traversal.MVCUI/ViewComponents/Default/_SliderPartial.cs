using Microsoft.AspNetCore.Mvc;

namespace Traversal.MVCUI.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
