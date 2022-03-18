using System;
using System.Collections.Generic;

namespace Homework05
{
    public class Order
    {
        public int Id { get; set; }
        public String Customer { get; set; }
        public List<OrderDetails> Data { get; set; }
        
        public int TotalCost { get; set; }

        public Order(int id, String customer, List<OrderDetails> data)
        {
            Id = id;
            Customer = customer;
            Data = data;
            TotalCost = 0;
            foreach (var detail in Data)
            {
                TotalCost += detail.Cost;
            }
        }
    }

    public class OrderDetails
    {
        public String Name { get; set; }
        public int Number { get; set; }
        public int Cost { get; set; }

        public OrderDetails(String name, int number, int cost)
        {
            Name = name;
            Number = number;
            Cost = cost;
        }
    }
}