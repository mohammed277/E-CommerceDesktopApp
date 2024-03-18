using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Contracts
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        IQueryable<Product> GetProductsByCategoryId(int categoryId);
        IQueryable<Product> SearchByName(string productName,int categoryId);
        void UpdateProductQuantity (int productid,int NewQuantity);
		IQueryable<Product> SortByNameAsc();
        IQueryable<Product> SortByNameDesc();
        IQueryable<Product> SortByPriceDesc();
        IQueryable<Product> SortByPriceAsc();

    }
}
