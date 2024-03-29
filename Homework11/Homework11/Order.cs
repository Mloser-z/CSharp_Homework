using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Homework11
{
    public class Order
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long OrderId { get; set; }
        [Required]
        public String Customer { get; set; }
        public List<OrderDetail> OrderDetails { get; set; }
        [Required]
        public int TotalCost { get; set; }
        
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public String Name { get; set; }
        [Required]
        public int Number { get; set; }
        [Required]
        public int Cost { get; set; }

        public long OrderId { get; set; }
        public Order Order { get; set; }
        
    }
}