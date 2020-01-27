using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CRUDGol.Data.Repository
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected AeroContext _context { get; set; }

        public BaseRepository(AeroContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IEnumerable<T> GetAll()
        {
            return this._context.Set<T>().ToList();
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this._context.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task<int> SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
