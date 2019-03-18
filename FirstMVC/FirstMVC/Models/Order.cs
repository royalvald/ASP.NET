using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models
{
    public class Order
    {
        [Key]
        public int OrderId { set; get; }
        [StringLength(50)]
        public string OrderCode { set; get; }
        
        public decimal OrderAmount { set; get; }

       public virtual List<OrderDetail> OrderDetail { set; get; }
    }
}