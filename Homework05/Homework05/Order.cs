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

        public Order()
        {
        }

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

        public override string ToString()
        {
            String order;
            order = "----" + Id + "----" + Customer + "----" + TotalCost + "----";
            foreach (var detail in Data)
            {
                order += ("\n" + detail);
            }

            return order;
        }

        public override bool Equals(object obj)
        {
            var order = obj as Order;
            bool flag = true;
            return order != null && Id == order.Id && Customer==order.Customer && Data.Equals(order.Data);
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }

    public class OrderDetails
    {
        public String Name { get; set; }
        public int Number { get; set; }
        public int Cost { get; set; }

        public OrderDetails() {}
        
        public OrderDetails(String name, int number, int cost)
        {
            Name = name;
            Number = number;
            Cost = cost;
        }

        public override string ToString()
        {
            return Name + "     |      " + Number + "     |      " + Cost;
        }

        public override bool Equals(object obj)
        {
            var orderDetail = obj as OrderDetails;
            return orderDetail != null && Name == orderDetail.Name && Number == orderDetail.Number &&
                   Cost == orderDetail.Cost;
        }

        public override int GetHashCode()
        {
            return 785010553 + base.GetHashCode();
        }
    }
}