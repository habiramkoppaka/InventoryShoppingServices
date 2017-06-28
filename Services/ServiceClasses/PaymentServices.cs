using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryShoppingServices.Models;
using InventoryShoppingServices.Services.ServiceInterface;
using System.Net.Http;
using System.Net.Http.Headers;

namespace InventoryShoppingServices.Services.ServiceClasses
{
    public class PaymentServices : IPaymentServices
    {
        public bool  ChargePayment(string creditCardNumber, int cvv, decimal amount)
        {
            if (!string.IsNullOrWhiteSpace(creditCardNumber) && amount > 0)
            {

                var Creditcardinfo = new PaymentCard
                {

                    CreditCardNumber = creditCardNumber,
                    CVV = cvv,
                    amount = amount

                };
                // Process the payment, Ideally we have to do credit card paymeny type checks, format etc
                // use async method HTTP Client to post the data to credit card services and recive responce

                /*using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri("http://creditcardpaymentgateway/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    StringContent content = new StringContent(JsonConvert.SerializeObject(Creditcardinfo));
                    // HTTP POST
                    HttpResponseMessage response = await client.PostAsync("api/payment/responce", content);
                    if (response.IsSuccessStatusCode)
                    {
                        string data = await response.Content.ReadAsStringAsync();
                        var responce = JsonConvert.DeserializeObject<>(data);
                    }
                    */


                    return true;

            }
            else
            {
                return false;
            }
            }
        }
    }

