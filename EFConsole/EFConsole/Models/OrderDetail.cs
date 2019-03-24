using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFConsole.Models
{
    class OrderDetail
    {
        [ForeignKey("Order")]
        public int OrderDetailId { set; get; }

        public decimal TotalAmount { set; get; }

        public virtual List<Product> Product { set; get; }
        
        public virtual Order Order { set; get; }
    }
}
