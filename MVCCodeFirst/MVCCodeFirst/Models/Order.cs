using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCCodeFirst.Models
{
    public class Order
    {
        
        public int OrderId { set; get; }

        [StringLength(50)]
        public string OrderCode { set; get; }

        public decimal TotalPrice { set; get; }

        //[ForeignKey("OrderDetail")]
       // public int OrderDetailId { set; get; }
      
        public virtual OrderDetail OrderDetail { set; get; }
    }
}