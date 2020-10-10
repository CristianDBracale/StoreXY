using StoreXY.DAL;
using System;

namespace StoreXY.DTOs
{
    public class ListOrderDTO
    {
        public long id { get; set; }
        public string customer_name { get; set; }
        public string customer_email { get; set; }
        public string customer_mobile { get; set; }
        public string status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime? updated_at { get; set; }
        public long idClient { get; set; }
        public string nameClient { get; set; }

        public ListOrderDTO() { }

        public ListOrderDTO(Orders order)
        {
            id = order.id;
            customer_name = order.customer_name;
            customer_email = order.customer_email;
            customer_mobile = order.customer_mobile;
            status = order.status;
            created_at = order.created_at;
            updated_at = order.updated_at;
            idClient = order.idClient;
            nameClient = order.Clients.name;
        }
    }
}
