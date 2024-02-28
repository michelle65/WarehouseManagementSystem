﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Domain
{
    public class LineItem
    {
        public Guid Id { get; set; }
        public Item Item { get; set; }
        public int Quantity { get; set; }
    }
}
