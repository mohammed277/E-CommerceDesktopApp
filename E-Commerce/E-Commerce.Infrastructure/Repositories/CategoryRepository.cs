using E_Commerce.Applications.Contracts;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Infrastructure.Repositories
{
    public class CategoryRepository :BaseRepository<Category> , ICategoryRepository
    {
        private ApplicationDbContext _context;
        public CategoryRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

		public void AddProductToCategory(Category category, Product product)
		{
            _context.Categories.Include(e => e.Products).FirstOrDefault(e => e.ID == category.ID).Products.Add(product);
            _context.SaveChanges();
		}

		public Category GetByName(string categoryName)
        {
            return _context.Categories.FirstOrDefault(C => C.Name == categoryName);
        }

		public IQueryable<Product> GetProductsByCategory(int categoryId)
		{
			return _context.Products.Include(e => e.Category).Where(e => e.Category.ID == categoryId);
		}

		public IQueryable<Category> SortByNameAsc()
        {
            return _context.Categories.OrderBy(C => C.Name);
        }
        public IQueryable<Category> SortByNameDesc()
        {
            return _context.Categories.OrderByDescending(C => C.Name);
        }

    }
}
