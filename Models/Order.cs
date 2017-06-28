using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShoppingServices.Models
{
    // order entity the data we are getting from user 
    public class Order
    {
        public int OrderId { get; set; }
        // product item that user choosen
        public Product Product  { get; set; }

        // Product Quantity that user requested for 
        public int Quantity{ get; set; }

        // payment info provided by user 
        public PaymentCard cardinfo { get; set; }
    }
}
