using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCodeFirst.Models
{
    public class OrderDetail
    {
        //[ForeignKey("Order")]
        public int OrderDetailId { set; get; }

        public decimal Total { set; get; }

        public string ProductList { set; get; }

       // [ForeignKey("Order")]
        //public int OrderId { set; get; }
        
        public virtual Order Order { set; get; }
        public virtual List<Product> Product { set; get; }
    }
}