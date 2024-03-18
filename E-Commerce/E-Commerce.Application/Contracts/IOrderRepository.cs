using E_Commerce.Domain.Enums;
using E_Commerce.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace E_Commerce.Applications.Contracts
{
    public interface IOrderRepository: IBaseRepository<Order>
    {
        Order ChangeStatus(int OrderId,int UserId, OrderState newStatus);

        IQueryable<Order> GetOrdersOfUser(int userId);
    }
}
