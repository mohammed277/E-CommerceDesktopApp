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
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private ApplicationDbContext _context;

        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<Product> GetProductsByCategoryId(int categoryId)
        {
            return _context.Products.Include(e => e.Category).Where(e => e.CategoryId == categoryId);
        }

        public IQueryable<Product> SearchByName(string productName, int categoryId)
        {
            if(categoryId==0)
            return _context.Products.Where(s => s.Name.Contains(productName));

            return _context.Products.Where(s => s.Name.Contains(productName) && s.CategoryId==categoryId);
        }

        public IQueryable<Product> SortByNameAsc()
        {
            return _context.Products.OrderBy(p => p.Name);
        }
        public IQueryable<Product> SortByNameDesc()
        {
            return _context.Products.OrderByDescending(p => p.Name);
        }

        public IQueryable<Product> SortByPriceAsc()
        {
            return _context.Products.OrderBy(p => p.Price);
        }
        public IQueryable<Product> SortByPriceDesc()
        {
            return _context.Products.OrderByDescending(p => p.Price);
        }

        public void UpdateProductQuantity(int productid, int NewQuantity)
        {
            _context.Products.FirstOrDefault(p => p.ID == productid).Quantity -= NewQuantity;
            Complete();
        }
    }
}
