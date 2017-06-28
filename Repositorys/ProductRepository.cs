using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryShoppingServices.Models;

namespace InventoryShoppingServices.Repositorys
{
    public class ProductRepository : IProductRepository
    {
        // return of total list of products

        public List<Product> GetAllProducts()
        {
            // List of data that is in inventory

            List<Product> productlist = new List<Product>()
            {
                new Product() { ProductID = 1, ProductName = "Item 1", price = 39.99m, Quantity = 05 },
                new Product() { ProductID = 2, ProductName = "Item 2", price = 72, Quantity = 1 },
                new Product() { ProductID = 3, ProductName = "Item 3", price = 16.91m, Quantity = 0 },
                new Product() { ProductID = 4, ProductName = "Item 4", price = 57.5m, Quantity = 50 },
                new Product() { ProductID = 5, ProductName = "Item 5", price = 10.9m, Quantity = 06 },
            };

            return productlist;
        }
        // return product based on ID
        public Product GetProductbyId(int productid)
        {
            return GetAllProducts().Find(p => p.ProductID == productid);
        }
    }
}
