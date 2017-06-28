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
    public class OrderProcessingServices : IOrderProcessingServices
    {
        private readonly IEmailServices emailservvices;
        private readonly IProductCheckServices productServices;
        private readonly IPaymentServices paymentServices;

        public OrderProcessingServices()
        {
            this.emailservvices = new EmailServices();
            this.paymentServices = new PaymentServices();
            this.productServices = new ProductCheckServices(new ProductRepository());
        }


        public bool OrderProcess(Order order)
        {
            if (order.Product != null)  // checking the model
            {
                // check wether orderproduct exist store
                var ProductExists = productServices.CheckInventory(order.Product.ProductID, order.Quantity);
                if (ProductExists)
                {
                    try
                    {
                        // process the payment
                        paymentServices.ChargePayment(order.cardinfo.CreditCardNumber, order.cardinfo.CVV, order.Product.price);
                    }
                    catch
                    {
                        throw new Exception("payment failed");
                    }
                    try
                    {
                        // Send Email to shipping dept
                        emailservvices.SendEmailtoShipDept(order);
                    }
                    catch
                    {
                        throw new SystemException("Email not sent");
                    }
                    return true;

                }
                else
                {
                    throw new Exception("Products Out of Stock");
                }
            }
            else
            {
                throw new Exception("product should be valid");
            }

        }
    }
}
