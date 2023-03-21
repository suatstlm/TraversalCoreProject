using Microsoft.AspNetCore.Mvc;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccesLayer.Concrete;
using Traversal.DataAccesLayer.EntityFramework;

namespace Traversal.MVCUI.ViewComponents.Default
{
    public class _Feature: ViewComponent
    {
        FeatureManager _featureManager = new(new EfFeatureDal());

        public IViewComponentResult Invoke()
        {
            var result = _featureManager.TGetAll();
            return View(result);
        }
    }
}
