using E_Commerce.Applications.Contracts;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Services
{
    public class CategoryService
    {
        ICategoryRepository _categoryRepository;
		public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public Category CreateCategory(Category category)
        {
            if (category is not null && _categoryRepository.GetByName(category.Name) is null)
            {
               return _categoryRepository.Create(category);
               
            }
            return null;
        }
        public bool DeleteCategory(Category category,int id)
        {
            if (category is not null&& GetProductsByCategory(id).ToList().Count==0)
            {
               return  _categoryRepository.Delete(category, id);
            }
            return false;
        }

		private IQueryable<Product> GetProductsByCategory(int id)
		{
            return _categoryRepository.GetProductsByCategory(id);
		}

		public IQueryable<Category> GetCategories()
        {
            return _categoryRepository.GetAll();
        }
        public Category GetCategory(int id)
        {
            if (id != 0)
            {
                return _categoryRepository.GetById(id);
            }
            return null;
        }
        public Category GetByName(string categoryName)
        {
            if (categoryName is not null)
            {
                return _categoryRepository.GetByName(categoryName);
            }
            return null;
        }
        public IQueryable<Category> OrderByCategoryNameAsc()
        {
            return _categoryRepository.SortByNameAsc();
        }
        public IQueryable<Category> OrderByCategoryNameDesc()
        {
            return _categoryRepository.SortByNameDesc();
        }
        public void AssignProductToCatgeory(Category category,Product product)
        {
            _categoryRepository.AddProductToCategory(category, product);
        }

		public bool UpdateCategory(Category category, int categoryId)
		{
            if (category is not null && _categoryRepository.GetByName(category.Name) is null)
			{

				return _categoryRepository.Update(category,categoryId);
			}
			return false;
		}
	}
}
