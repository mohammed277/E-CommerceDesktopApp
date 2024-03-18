using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Dtos.OrdersDto
{
	public class DisplayOrderForUserDto
	{
		public decimal FinalPrice { get; set; }
		public DateTime Date { get; set; }
		public OrderState State { get; set; }
	}
}
