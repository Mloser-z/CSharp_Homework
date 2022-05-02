using System;
using System.Collections.Generic;
using System.Data.Entity;
using MySql.Data.EntityFramework;

namespace Homework11
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        public OrderContext() : base("OrderDB")
        {
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<OrderContext>());
        }
    }
}