using System;
using Homework05;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace TestOrderApp
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void TestAdd()
        {
            List<Order> tests = new List<Order>()
            {
                new Order(0, "A", new List<OrderDetails>()
                {
                    new OrderDetails("book", 23, 343),
                    new OrderDetails("apple", 34, 3435),
                    new OrderDetails("phone", 234, 2424)
                }),
                new Order(1, "A", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                }),
                new Order(2, "B", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                })
            };
            
            OrderService server = new OrderService();
            foreach (var test in tests)
            {
                server.AddOrder(test.Customer, test.Data);
            }
            Assert.AreEqual(tests, server.orders);
        }

        [Test]
        public void TestFindById()
        {
            List<Order> tests = new List<Order>()
            {
                new Order(0, "A", new List<OrderDetails>()
                {
                    new OrderDetails("book", 23, 343),
                    new OrderDetails("apple", 34, 3435),
                    new OrderDetails("phone", 234, 2424)
                }),
                new Order(1, "A", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                }),
                new Order(2, "B", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                })
            };
            
            OrderService server = new OrderService();
            foreach (var test in tests)
            {
                server.AddOrder(test.Customer, test.Data);
                Assert.AreEqual(test, server.FindById(test.Id));
            }
        }

        [Test]
        public void TestFindByCustomer()
        {
            List<Order> tests = new List<Order>()
            {
                new Order(0, "A", new List<OrderDetails>()
                {
                    new OrderDetails("book", 23, 343),
                    new OrderDetails("apple", 34, 3435),
                    new OrderDetails("phone", 234, 2424)
                }),
                new Order(1, "A", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                }),
                new Order(2, "B", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                })
            };
            
            OrderService server = new OrderService();
            foreach (var test in tests)
            {
                server.AddOrder(test.Customer, test.Data);
            }

            IEnumerable<Order> an = new List<Order>(){tests[1], tests[0]};
            Assert.AreEqual(an, server.FindByCustomer("A"));
        }

        [Test]
        public void TestDelete()
        {
            List<Order> tests = new List<Order>()
            {
                new Order(0, "A", new List<OrderDetails>()
                {
                    new OrderDetails("book", 23, 343),
                    new OrderDetails("apple", 34, 3435),
                    new OrderDetails("phone", 234, 2424)
                }),
                new Order(1, "A", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                }),
                new Order(2, "B", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                })
            };
            
            OrderService server = new OrderService();
            foreach (var test in tests)
            {
                server.AddOrder(test.Customer, test.Data);
            }

            List<Order> an = new List<Order>() {tests[0], tests[2]};
            an[1].Id = 1;
            server.Delete(1);
            Assert.AreEqual(an, server.orders);
        }

        [Test]
        public void TestChangeOrderAdd()
        {
            List<Order> tests = new List<Order>()
            {
                new Order(0, "A", new List<OrderDetails>()
                {
                    new OrderDetails("book", 23, 343),
                    new OrderDetails("apple", 34, 3435),
                    new OrderDetails("phone", 234, 2424)
                }),
                new Order(1, "A", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                }),
                new Order(2, "B", new List<OrderDetails>()
                {
                    new OrderDetails("table", 2432, 5435),
                    new OrderDetails("sk", 242, 12)
                })
            };
            
            OrderService server = new OrderService();
            foreach (var test in tests)
            {
                server.AddOrder(test.Customer, test.Data);
            }

            OrderDetails changeAddDetail = new OrderDetails("table", 23, 2234);
            tests[0].Data.Add(changeAddDetail);
            
            server.ChangeOrderAdd(0, changeAddDetail);
            Assert.AreEqual(tests, server.orders);
        }
        
        
    }
}