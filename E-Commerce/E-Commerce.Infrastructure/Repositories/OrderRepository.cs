using E_Commerce.Applications.Contracts;
using E_Commerce.Domain.Enums;
using E_Commerce.Domain.Models;
using E_Commerce.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Infrastructure.Repositories
{
   public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
		private ApplicationDbContext _context;

		public OrderRepository(ApplicationDbContext context) :base(context)
        {
            _context = context;
        }

        public Order ChangeStatus(int OrderId,int UserId, OrderState newStatus)
		{
            Order order = _context.Orders.FirstOrDefault(e => e.UserID == UserId && e.ID == OrderId);
            order.State = newStatus;
            _context.SaveChanges();
            return order;
        }

		public IQueryable<Order> GetOrdersOfUser(int userId)
		{
            return _context.Orders.Where(e => e.UserID == userId).Include(e => e.OrderDetails);
		}
	}
}
