using AutoMapper;
using E_Commerce.Domain.Dtos;
using E_Commerce.Domain.Dtos.OrdersDto;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Applications.Mapper
{
	public class Mapping
	{
		public static IMapper MappingDisplayCategory()
		{

			var config = new MapperConfiguration(c =>
			{
				c.CreateMap<Category, DisplayCategoryDto>();
			});
			return config.CreateMapper();
		}

		public static IMapper MappingAddCategory()
		{

			var config = new MapperConfiguration(c =>
			{
				c.CreateMap<AddCategoryDto, Category>();
			});
			return config.CreateMapper();
		}

		public static IMapper MappingAddAdmin()
		{

			var config = new MapperConfiguration(c =>
			{
				c.CreateMap<AddAdminDto,User>();
			});
			return config.CreateMapper();
		}

		public static IMapper MappingAddCustomer()
		{

			var config = new MapperConfiguration(c =>
			{
				c.CreateMap<AddCustomerDto, User>();
			});
			return config.CreateMapper();
		}

		public static IMapper MappingAddProduct()
		{

			var config = new MapperConfiguration(c =>
			{
				c.CreateMap<AddProductDto, Product>();
			});
			return config.CreateMapper();
		}

		public static IMapper MappingDisplayProduct()
		{

			var config = new MapperConfiguration(c =>
			{
				c.CreateMap<Product,DisplayProductDto>()
				.ForMember(dto=>dto.CategoryName,prd=>prd.MapFrom(catName=>catName.Category.Name));
			});
			return config.CreateMapper();
		}

		public static IMapper MappingDisplayOrdersOfUser()
		{

			var config = new MapperConfiguration(c =>
			{
				c.CreateMap<Order, DisplayOrderForUserDto>();
			});
			return config.CreateMapper();
		}

        public static IMapper MappingDisplayAllOrders()
        {

            var config = new MapperConfiguration(c =>
            {
				c.CreateMap<Order, DisplayOrderDto>()
				.ForMember(dto => dto.Email, src => src.MapFrom(email => email.User.Email))
				.ForMember(dto => dto.FullName, src => src.MapFrom(email => email.User.Name));
            });
            return config.CreateMapper();
        }

    }
}
