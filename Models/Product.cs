using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShoppingServices.Models
{     // product entity in inventory
    public class Product
    {
        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public decimal price { get; set; }
        public int Quantity { get; set; }

    }
}
