using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryShoppingServices.Models;
using InventoryShoppingServices.Services.ServiceInterface;
using InventoryShoppingServices.Repositorys;

namespace InventoryShoppingServices.Services.ServiceClasses
{
    public class ProductCheckServices : IProductCheckServices
    {
        private readonly IProductRepository productRepository;

        public ProductCheckServices(IProductRepository productRepository)
        {
            this.productRepository = productRepository;

        }
        // Checking the  inventory of the product from store
        // and If there are enough quantities in the store return true
        public bool CheckInventory(int productId, int quantity)
        {
            // checks for product and quantity


            var productinventorycheck = productRepository.GetAllProducts().FirstOrDefault(x => x.ProductID == productId && x.Quantity >= quantity);


            if (productinventorycheck != null)
            {
                return true;
            }
            else
            {
                return false;

            }


        }
    }
}
