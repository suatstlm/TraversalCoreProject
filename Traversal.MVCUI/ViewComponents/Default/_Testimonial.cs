using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccesLayer.EntityFramework;

namespace Traversal.MVCUI.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        TestimonialManager _testimonialManager = new(new EfTestimonialDal());

        public IViewComponentResult Invoke()
        {
            var result = _testimonialManager.TGetAll();
            return View(result);  
        }
    }
}
