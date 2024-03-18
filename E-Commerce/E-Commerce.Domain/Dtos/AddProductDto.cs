using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Dtos
{
    public class AddProductDto
	{
        public string Name { get; set; }

        //static private int nextId = 1;
        //static public int NextId
        //{
        //    get { return nextId++; }
        //}

        //public AddProductDto()
        //{
        //    ID = NextId;
        //}
        public string? Description { get; set; }
        public string? Image { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public int CategoryId { get; set; }

    }
}
