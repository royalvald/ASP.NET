using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FirstMVC.Models
{
    public class MVCFirstContext : DbContext
    {
        public MVCFirstContext() : base("name=MVCFirstContext") { }
        public DbSet<Order> Order { set; get; }
        public DbSet<OrderDetail> OrderDetail { set; get; }
    }
}