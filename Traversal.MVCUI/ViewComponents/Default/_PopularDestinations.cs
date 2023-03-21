using Microsoft.AspNetCore.Mvc;
using System.Security.Permissions;
using Traversal.BusinessLayer.Concrete;
using Traversal.DataAccesLayer.EntityFramework;
using Traversal.EntityLayer.Concrete;

namespace Traversal.MVCUI.ViewComponents.Default
{
    public class _PopularDestinations : ViewComponent
    {
        DestinationManager _destinationManager = new(new EfDestinationDal());

        public IViewComponentResult Invoke()
        {
            var result = _destinationManager.TGetAll();
            return View(result);
        }
    }
}
