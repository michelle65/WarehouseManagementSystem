﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManagementSystem.Domain;

namespace WarehouseManagementSystem.Business
{
    public class OrderProcessor
    {
        private void Initialize(Order order)
        {
            Console.WriteLine($"Initializing Order with Order Number: {order.Id}");
        }

        public void Process(Order order)
        {
            Initialize(order);

            Console.WriteLine($"Finalizing Order Processing for Order Number: {order.Id}");
        }
    }
}
