using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryShoppingServices.Models;
using InventoryShoppingServices.Services.ServiceInterface;
using System.Net.Mail;

namespace InventoryShoppingServices.Services.ServiceClasses

{
    public class EmailServices : IEmailServices
    {
        public void SendEmailtoShipDept(Order order)
        {

                var mail = new MailMessage { From = new MailAddress("Shipping.Deparment@company.com") };
                mail.To.Add(new MailAddress("admin@company.com"));
                mail.Subject = "Subject " + DateTime.Now;
                mail.Body = "Order info"+ order.OrderId;
                var server = new SmtpClient { Host = "your.smtp.server" };

               // server.Send(mail);


        }
    }

}
