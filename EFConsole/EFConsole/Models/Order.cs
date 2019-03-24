
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EFConsole.Models
{
    class Order
    {
        public int OrderId { set; get; }

        public decimal Amount { set; get; }

        public DateTime Time { set; get; }

        public virtual OrderDetail OrderDetail { set; get; }
    }
}