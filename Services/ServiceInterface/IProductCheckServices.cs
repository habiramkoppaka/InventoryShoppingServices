using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryShoppingServices.Services.ServiceInterface
{
    public interface IProductCheckServices
    {
        bool CheckInventory(int productId, int quantity);
    }
}
