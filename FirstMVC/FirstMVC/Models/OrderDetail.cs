using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace FirstMVC.Models
{
    public class OrderDetail
    {
        [Key]
        public int OrderDetailId { set; get; }
        public decimal Price { set; get; }
        public int Count { set; get; }
        
        public int OrderId { set; get; }
        
        public virtual Order Order { set; get; }
    }
}