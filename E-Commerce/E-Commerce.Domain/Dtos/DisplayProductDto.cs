using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Dtos
{
	public class DisplayProductDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public string? Image { get; set; }
		public int Quantity { get; set; }
		public decimal Price { get; set; }
        public string CategoryName { get; set; }
    }
}
