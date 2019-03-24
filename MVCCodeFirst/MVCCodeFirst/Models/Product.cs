using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVCCodeFirst.Models
{
    public class Product
    {
        public int ProductId { set; get; }

        [StringLength(50)]
        public string ProductName { set; get; }

        public virtual OrderDetail OrderDetail { set; get; }
    }
}