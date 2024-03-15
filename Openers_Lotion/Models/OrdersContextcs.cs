using Microsoft.EntityFrameworkCore;
using ProductStore.Models;

namespace Openers_Lotion.Models
{
    public class OrdersContextcs
    {
    }
    public class OrdersContext : DbContext
    {
        public OrdersContext() : base("name=OrdersContext")
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
    }