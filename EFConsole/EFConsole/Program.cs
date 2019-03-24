using EFConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            
            using (EFTestContext db = new EFTestContext())
            {
                db.Order.Add(
                    new Order { Amount = 700, Time = DateTime.Now });
                db.SaveChanges();
            }
        }
    }
}
