using PlacetoPay.Integrations.Library.CSharp.Contracts;
using PlacetoPay.Integrations.Library.CSharp.Entities;
using PlacetoPay.Integrations.Library.CSharp.Message;
using StoreXY.CrossLayer.Enum;
using StoreXY.DTOs;
using System;
using System.Net;
using System.Net.Sockets;

namespace StoreXY.APIPlaceToPay
{
    public class PlaceToPay
    {
        public void Pay(OrderToPayDTO orderToPayDTO)
        {
            Gateway gateway = new PlacetoPay.Integrations.Library.CSharp.PlacetoPay("6dd490faf9cb87a9862245da41170ff2",
                                      "024h1IlD",
                                      new Uri("https://test.placetopay.com/redirection/"),
                                      Gateway.TP_REST);


            Amount amount = new Amount(orderToPayDTO.Price);
            Payment payment = new Payment("Pay_" + orderToPayDTO.Id, "", amount);
            var host = Dns.GetHostEntry(Dns.GetHostName());
            string IPAddressUsed = string.Empty;
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    IPAddressUsed = ip.ToString();
                }
            }
            RedirectRequest request = new RedirectRequest(payment,
                "https://localhost:44369/Order",
                IPAddressUsed,
                "Chrome",
                DateTime.Now.AddDays(1).ToString("yyyy-MM-dd'T'HH:mm:ss.fffffff'Z'"));

            RedirectResponse response = gateway.Request(request);

            if (response.IsSuccessful())
            {
                BusinessModel.Gateway.UpdateOrder(orderToPayDTO.Id, OrderStatusEnum.PAYED.ToString());
            }
            else if (response.Status.status == "ERROR") 
            {
                BusinessModel.Gateway.UpdateOrder(orderToPayDTO.Id, OrderStatusEnum.REJECTED.ToString());
            }
        }
    }
}
