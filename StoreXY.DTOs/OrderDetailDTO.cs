using StoreXY.DAL;
using System;
using System.ComponentModel.DataAnnotations;

namespace StoreXY.DTOs
{
    public class OrderDetailDTO
    {
        public long Id { get; set; }
        [Display(Name = "Name of product")]
        public string NameOfProduct { get; set; }
        [Display(Name = "Product price")]
        public decimal ProductPrice { get; set; }
        [Display(Name = "Client name")]
        public string NameClient { get; set; }
        [Display(Name = "Client phone")]
        public string MobileClient { get; set; }
        [Display(Name = "Client Email")]
        public string EmailClient { get; set; }
        [Display(Name = "Order created")]
        public DateTime CreatedAt { get; set; }

        #region Constructors
        public OrderDetailDTO() { }

        public OrderDetailDTO(Orders order)
        {
            Id = order.id;
            NameOfProduct = order.Products1.name;
            ProductPrice = order.Products1.price;
            NameClient = order.customer_name;
            MobileClient = order.customer_mobile;
            EmailClient = order.customer_email;
            CreatedAt = order.created_at;
        }

        #endregion
    }
}
