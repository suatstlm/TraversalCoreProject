using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccesLayer.EntityFramework;

namespace Traversal.MVCUI.ViewComponents.Default
{
    public class _SubAbout: ViewComponent
    {
        SubAboutManager _subAboutManager = new(new EfSubAboutDal());
        public IViewComponentResult Invoke() 
        {
            var result = _subAboutManager.TGetAll();
            return View(result); 
        }
    }
}
