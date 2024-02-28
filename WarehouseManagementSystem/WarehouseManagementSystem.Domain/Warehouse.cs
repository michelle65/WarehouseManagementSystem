using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManagementSystem.Domain
{
    public class Warehouse
    {
        public Guid Id { get; set; }
        public string Location { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
