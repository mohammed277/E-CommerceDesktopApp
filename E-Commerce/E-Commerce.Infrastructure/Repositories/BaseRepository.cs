using E_Commerce.Applications.Contracts;
using E_Commerce.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public T Create(T entity)
        {
            _context.Set<T>().Add(entity);
			Complete();
			return entity;
        }
		public bool Delete(T entity, int id)
		{
			T existingEntity = GetById(id);
			try
			{
				_context.Set<T>().Remove(existingEntity);
				Complete();
				return true;
			}
			catch 
			{
				return false;
			}
		}

		public IQueryable<T> GetAll()
        {
            return _context.Set<T>();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public bool Update(T entity, int id)
        {
			var existingEntity = _context.Set<T>().Find(id);
			try
			{
				_context.Entry(existingEntity).CurrentValues.SetValues(entity);
				Complete();
				return true;
			}
			catch
			{
				return false;
			}
		}
    }
}
