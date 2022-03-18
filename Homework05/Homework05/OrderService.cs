using System;
using System.Collections.Generic;
using System.Linq;

namespace Homework05
{
    public class OrderService
    {
        private List<Order> orders;
        private int idc = 0;

        public Order FindById(int id)
        {
            var query = from order in orders where (order.Id == id) select order;
            if (query == null)
            {
                throw new Exception("No Found!");
            }
            return query.FirstOrDefault();
        }

        public IEnumerable<Order> FindByCustomer(String customer)
        {
            var query = from order in orders where (order.Customer == customer) orderby order.TotalCost select order;
            if (query == null)
            {
                throw new Exception("No Found!");
            }
            return query;
        }

        public void AddOrder(String customer, List<OrderDetails> data)
        {
            Order order = new Order(idc, customer, data);
            idc++;
            orders.Add(order);
        }

        public void Delete(int id)
        {
            try
            {
                Order d = FindById(id);
                orders.Remove(d);
            }
            catch (Exception e)
            {
                throw new Exception("Nothing to delete!");
            }
           
        }

        public void Delete(String customer)
        {
            IEnumerable<Order> d = FindByCustomer(customer);
            try
            {
                foreach (var order in d)
                {
                    orders.Remove(order);
                }
            }
            catch (Exception e)
            {
                throw new Exception("Nothing to delete!");
            }
        }

        public void ChangeOrderAdd(int id, OrderDetails detail)
        {
            Order order;
            try
            {
                order = FindById(id);
                order.Data.Add(detail);
            }
            catch (Exception e)
            {
                throw new Exception("Can not change because no order is found!");
            }
        }

        public void ChangeOrderDelete(int id, String detailName)
        {
            Order order;
            try
            {
                order = FindById(id);
                int flag = 0;
                foreach (var detail in order.Data)
                {
                    if (detail.Name == detailName)
                    {
                        order.Data.Remove(detail);
                        flag = 1;
                    }
                }

                if (flag == 0)
                {
                    throw new Exception("Can not change because order has no name" + detailName);
                }

            }
            catch (Exception e)
            {
                throw new Exception("Can not change because no order is found!");
            }
        }
    }
}