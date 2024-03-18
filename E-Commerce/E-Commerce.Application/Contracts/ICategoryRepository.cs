using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Contracts
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        void AddProductToCategory(Category category,Product product);
		IQueryable<Product> GetProductsByCategory(int categoryId);
		Category GetByName(string categoryName);
        IQueryable<Category> SortByNameAsc();
        IQueryable<Category> SortByNameDesc();

    }
}
