using eCommerse.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerse.DAL.Data
{
    public class DataContext : DbContext
    {
        // You can either pass the NAME of a connection string, and explicity declare
        public DataContext() : base("DefaultConnection")
        {

        }

        // <summary>
        // any entity to be persisted ,ust be declared here
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Customer> Customers  { get; set; }

    }
}
