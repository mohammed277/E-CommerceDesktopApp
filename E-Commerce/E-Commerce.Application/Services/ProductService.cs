using E_Commerce.Applications.Contracts;
using E_Commerce.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Services
{
    public class ProductService 
    {
        IProductRepository _productRepository;
		public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
		}
        public Product CreateProduct(Product product)
        {
            if (product is not null)
            {
                var prod = _productRepository.Create(product);
                _productRepository.Complete();
                return prod;
            }
            return null;
        }
        public bool UpdateProduct(Product product,int id)
        {
            if (product is not null)
            {
                return  _productRepository.Update(product,id);
            }
            return false;
        }
        public bool DeleteProduct(Product product, int id)
        {
            if (product is not null)
            {
                bool prod =  _productRepository.Delete(product,id);
                _productRepository.Complete();
                return prod;
            }
            return false;
        }
        public IQueryable<Product> GetProducts()
        {
            return _productRepository.GetAll().Include(e=>e.Category);
        }
        public Product GetProduct(int id)
        {
            if (id != 0)
            {
                return _productRepository.GetById(id);
            }
            return null;
        }
        public IQueryable<Product> SearchByName(string productName,int categoryId)
        {
            if (productName is not null)
            {
                return _productRepository.SearchByName(productName,categoryId);
            }
            return null;
        }
        public void updateQuantity(int productid,int quantity)
        {
            if (productid > 0 && quantity >0)
            {
                _productRepository.UpdateProductQuantity(productid,quantity);
            }
        }

        public IQueryable<Product> GetProductsByCategoryId(int categoryId)
        {
            if (categoryId <= 0)
                return null;
            return _productRepository.GetProductsByCategoryId(categoryId);
        }
        public IQueryable<Product> OrderByProductNameAsc()
        {
            return _productRepository.SortByNameAsc();
        }
        public IQueryable<Product> OrderByProductNameDesc()
        {
            return _productRepository.SortByNameDesc();
        }
        public IQueryable<Product> OrderByProductPriceAsc()
        {
            return _productRepository.SortByPriceAsc();
        }
        public IQueryable<Product> OrderByProductPriceDesc()
        {
            return _productRepository.SortByPriceDesc();
        }

    }
}
