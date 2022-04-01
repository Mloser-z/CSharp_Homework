using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Homework05
{
    [Serializable]
    public class OrderService
    {
        public List<Order> orders;

        public OrderService()
        {
            orders = new List<Order>();
        }
        

        // 查找order
        public Order FindById(int id)
        {
            var query = from order in orders where (order.Id == id) select order;
            if (query.FirstOrDefault() == null)
            {
                throw new Exception("No Found!");
            }

            return query.FirstOrDefault();
        }

        // 查找order
        public IEnumerable<Order> FindByCustomer(String customer)
        {
            var query = from order in orders where (order.Customer == customer) orderby order.TotalCost select order;
            if (query.FirstOrDefault() == null)
            {
                throw new Exception("No Found");
            }

            return query;
        }

        // 添加order
        public void AddOrder(String customer, List<OrderDetails> data)
        {
            Order order = new Order(orders.Count, customer, data);
            orders.Add(order);
        }

        // 删除order根据id
        public void Delete(int id)
        {
            try
            {
                Order d = FindById(id);
                orders.Remove(d);
                foreach (var order in orders)
                {
                    if (order.Id > id)
                    {
                        order.Id--;
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + ": Nothing to delete");
            }
        }

        // 删除id根据customer
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
                throw new Exception(e.Message + ": Nothing to delete");
            }
        }

        // 针对id的order进行添加
        public void ChangeOrderAdd(int id, OrderDetails detail)
        {
            
            try
            {
                var order = FindById(id);
                order.Data.Add(detail);
                order.TotalCost += detail.Cost;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + ": Can not change because no order is found");
            }
        }

        // 针对id的order进行删除
        public void ChangeOrderDelete(int id, String detailName)
        {
            try
            {
                var order = FindById(id);
                int flag = 0;
                var query = from detail in order.Data where (detail.Name == detailName) select detail;

                if (query.FirstOrDefault() != null)
                {
                    order.Data.Remove(query.First());
                    order.TotalCost -= query.First().Cost;
                    flag = 1;
                }

                if (flag == 0)
                {
                    throw new Exception("Can not change because order has no name: " + detailName);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + ": Can not change because no order is found");
            }
        }

        // 针对id的order进行修改
        public void ChangeOrderChange(int id, OrderDetails detail)
        {
            try
            {
                var order = FindById(id);
                int flag = 0;
                var query = from d in order.Data where (d.Name == detail.Name) select d;

                if (query.FirstOrDefault() != null)
                {
                    order.TotalCost = order.TotalCost - query.First().Cost + detail.Cost;
                    query.First().Cost = detail.Cost;
                    query.First().Number = detail.Number;
                    flag = 1;
                }

                if (flag == 0)
                {
                    throw new Exception("Can not change because order has no name: " + detail.Name);
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message + ": Can not change because no order is found");
            }
        }

        public void Export()
        {
            using (FileStream fs = new FileStream("orders.xml", FileMode.Create))
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
                xmlser.Serialize(fs, orders);
            }
        }

        public void Import()
        {
            try
            {
                using (FileStream fs = new FileStream("orders.xml", FileMode.Open))
                {
                    XmlSerializer xmlser = new XmlSerializer(typeof(List<Order>));
                    List<Order> xmlOrders = (List<Order>)xmlser.Deserialize(fs);
                    if (xmlOrders == null)
                    {
                        throw new Exception("读取错误");
                    }
                    else
                    {
                        orders = xmlOrders;
                    }
                }
            }
            catch (FileNotFoundException e)
            {
                throw new Exception("文件不存在");
            }
            catch (Exception e)
            {
                throw new Exception("读取错误");
            }
            
        }
        
    }
}