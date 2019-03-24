using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MVCCodeFirst.Models
{
    public class ShopInfo : DbContext
    {
        public ShopInfo() : base("name=ShopInfoContext") { }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetail> OrderDetail { set; get; }
        // public DbSet<Product> Product { set; get; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
               .HasOptional(s => s.OrderDetail)
                .WithRequired(ad => ad.Order);

        }
    }
}