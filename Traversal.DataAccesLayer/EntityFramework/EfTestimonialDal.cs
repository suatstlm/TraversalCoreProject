using Traversal.DataAccesLayer.Abstract;
using Traversal.DataAccesLayer.Repository;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccesLayer.EntityFramework
{
    public class EfTestimonialDal : GenericRepository<Testimonial>, ITestimonialDal
    {
    }
}
