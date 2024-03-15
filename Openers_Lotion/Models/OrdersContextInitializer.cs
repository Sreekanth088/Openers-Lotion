namespace ProductStore.Models
{
    using Openers_Lotion.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;

    public class DropCreateDatabaseIfModelChanges<OrdersContext>
    {
        protected override void Seed(OrdersContext context)
        {
            var products = new List<Product>()
            {
               
            };

            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();

            var order = new Order() { Customer = "Bob" };
            var od = new List<OrderDetail>()
            {
                new OrderDetail() { Product = products[0], Quantity = 2, Order = order},
                new OrderDetail() { Product = products[1], Quantity = 4, Order = order }
            };
            context.Orders.Add(order);
            od.ForEach(o => context.OrderDetails.Add(o));

            context.SaveChanges();
        }
    }
}