using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccesLayer.Abstract;
using Traversal.DataAccesLayer.Repository;
using Traversal.EntityLayer.Concrete;

namespace Traversal.DataAccesLayer.EntityFramework
{
    public class EfAboutDal: GenericRepository<About>, IAboutDal
    {
    }
}
