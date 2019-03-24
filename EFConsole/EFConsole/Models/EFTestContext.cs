using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace EFConsole.Models
{
    class EFTestContext : DbContext
    {
        
        public EFTestContext() : base("name=EFTestContext") { }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetail> OrderDetail { set; get; }
        public DbSet<Product> Product { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().
              HasOptional(a => a.OrderDetail).
              WithRequired(b => b.Order);
                
        }
    }
}
