using E_Commerce.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce.Domain.Models
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public decimal FinalPrice { get; set; }
        public DateTime Date { get; set; }
        public OrderState State { get; set; }
        [ForeignKey("User")]
        public int UserID { get; set; }
        public User? User { get; set; }
        public List<OrderDetails> OrderDetails { get; set; }
    }
}
