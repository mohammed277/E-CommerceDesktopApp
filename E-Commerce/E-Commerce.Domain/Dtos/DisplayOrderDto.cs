using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Dtos
{
    public class DisplayOrderDto
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public OrderState State { get; set; }
        public DateTime Date { get; set; }
        public decimal FinalPrice { get; set; }
    }
}
