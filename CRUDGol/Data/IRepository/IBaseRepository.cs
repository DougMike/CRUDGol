using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRUDGol.Data
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);
        Task<int> SaveChanges();
    }
}
