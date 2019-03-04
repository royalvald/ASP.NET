﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Infrastructure;
namespace SearchTest
{
    class Program
    {
        static void Main(string[] args)
        {
           
        }

        static void Add()
        {
            using (Model1Entities db = new Model1Entities())
            {
                CustomerSet customer1 = new CustomerSet { Name = "楚留香1", Age = 27, CompanyName = "大旗门", Telphone = "13184841" };
                CustomerSet customer2 = new CustomerSet { Name = "楚留香2", Age = 27, CompanyName = "大旗门", Telphone = "154613" };

                CustomerSet customer3 = new CustomerSet { Name = "楚留香3", Age = 27, CompanyName = "大旗门", Telphone = "131313" };

                db.CustomerSet.Add(customer1);
                db.CustomerSet.Add(customer2);
                db.CustomerSet.Add(customer3);

                db.SaveChanges();
            }
        }
    }
}
