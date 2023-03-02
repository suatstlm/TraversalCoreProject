using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Traversal.DataAccesLayer.Abstract;
using Traversal.DataAccesLayer.Concrete;

namespace Traversal.DataAccesLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T t)
        {
            using var context = new TraversalDBContext();
            context.Remove(t);
            context.SaveChanges();
        }

        public List<T> GetList()
        {
            using var context = new TraversalDBContext();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new TraversalDBContext();
            context.Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new TraversalDBContext();
            context.Update(t);
            context.SaveChanges(); 
        }
    }
}
