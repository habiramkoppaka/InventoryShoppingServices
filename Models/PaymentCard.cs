using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShoppingServices.Models
{
    public class PaymentCard
    {

        public string CreditCardNumber { get; set; }

        public int Expirydate { get; set; }

        public int CVV { get; set; }


        public string cardholdername { get; set; }

        public decimal amount { get; set; }

    }
}
