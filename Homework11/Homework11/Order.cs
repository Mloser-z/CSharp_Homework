using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Homework11
{
    public class Order
    {
        public int OrderId { get; set; }
        [Required]
        public String Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [Required]
        public int TotalCost { get; set; }
        
    }

    public class OrderDetail
    {
        [Key]
        public String Name { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Cost { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
        
    }
}