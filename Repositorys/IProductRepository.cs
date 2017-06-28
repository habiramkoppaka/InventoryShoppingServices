using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryShoppingServices.Models;
using InventoryShoppingServices.Services.ServiceInterface;

namespace InventoryShoppingServices.Repositorys
{
    public interface IProductRepository
    {

        List<Product> GetAllProducts();

        Product GetProductbyId(int productid);
    }
}
