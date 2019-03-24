using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace EFConsole.Models
{
    class Product
    {
        public int ProductId { set; get; }

        [StringLength(50)]
        public string ProductName { set; get; }

        public decimal ProductPrice { set; get; }

      
    }
}
