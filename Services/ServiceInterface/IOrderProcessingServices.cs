using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryShoppingServices.Models;

namespace InventoryShoppingServices.Services.ServiceInterface
{
    public interface IOrderProcessingServices
    {   
        bool OrderProcess(Order order);
    }
}
