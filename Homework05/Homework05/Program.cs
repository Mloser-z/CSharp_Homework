using System;
using System.Collections.Generic;


namespace Homework05
{
    internal class Program
    {
        public static void Add(ref List<OrderDetails> data, String name, String number, String cost)
        {
            try
            {
                data.Add(new OrderDetails(name, Convert.ToInt32(number), Convert.ToInt32(cost)));
            }
            catch (Exception)
            {
                throw new Exception("Error. Input again.");
            }
        }

        public static void Main(string[] args)
        {
            OrderService service = new OrderService();
            try
            {
                service.Import();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(
                "Welcome to OrderService: -a add      -ca changeOrderAdd        -cc changeOrderDetail" +
                "       -cd changeOrderDelete       -dc deleteByCustomer      -di deleteById       -fc findById" +
                "        -fi findById        -q quit");
            
            while (true)
            {
                Console.Write(">");
                String opt = Console.ReadLine();
                switch (opt)
                {
                    case "a":
                        Console.Write("input Customer's Name: ");
                        String customer = Console.ReadLine();
                        List<OrderDetails> data = new List<OrderDetails>();
                        while (true)
                        {
                            try
                            {
                                Console.WriteLine("input order detail: name, number, cost");
                                Add(ref data, Console.ReadLine(), Console.ReadLine(), Console.ReadLine());
                                Console.WriteLine("if continue? y/n");
                                if (Console.Read() == 'n')
                                {
                                    service.AddOrder(customer, data);
                                    break;
                                }
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }

                        break;

                    case "ca":
                        try
                        {
                            Console.WriteLine("change order's id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("input order detail: name, number, cost");
                            OrderDetails newOrderDetails = new OrderDetails(Console.ReadLine(),
                                Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            try
                            {
                                service.ChangeOrderAdd(id, newOrderDetails);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("input Error.");
                        }

                        break;

                    case "cc":
                        try
                        {
                            Console.WriteLine("change order's id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("input order detail: name, number, cost");
                            OrderDetails newOrderDetails = new OrderDetails(Console.ReadLine(),
                                Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
                            try
                            {
                                service.ChangeOrderChange(id, newOrderDetails);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("input Error.");
                        }

                        break;

                    case "cd":
                        try
                        {
                            Console.WriteLine("change order's id: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("detail's name: ");
                            String name = Console.ReadLine();
                            try
                            {
                                service.ChangeOrderDelete(id, name);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("input Error.");
                        }

                        break;

                    case "dc":
                        try
                        {
                            Console.WriteLine("input delete customer");
                            service.Delete(Console.ReadLine());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case "di":
                        try
                        {
                            Console.WriteLine("input delete id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                service.Delete(id);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("input error.");
                        }

                        break;

                    case "fc":
                        try
                        {
                            Console.WriteLine("input customer:");
                            foreach (var order in service.FindByCustomer(Console.ReadLine()))
                            {
                                Console.WriteLine(order);
                            }
                            
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;

                    case "fi":
                        try
                        {
                            Console.WriteLine("input delete id:");
                            int id = Convert.ToInt32(Console.ReadLine());
                            try
                            {
                                Console.WriteLine(service.FindById(id));
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("input error.");
                        }

                        break;

                    case "q":
                        service.Export();
                        Console.WriteLine("quit.");
                        return;
                }
            }
        }
    }
}