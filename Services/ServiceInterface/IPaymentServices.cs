using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShoppingServices.Services.ServiceInterface
{
    public interface IPaymentServices
    {
        bool ChargePayment(string creditCardNumber,int cvv, decimal amount);
    }
}
