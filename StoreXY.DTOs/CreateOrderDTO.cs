using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace StoreXY.DTOs
{
    public class CreateOrderDTO
    {
        public List<SelectListItem> Products { get; set; }
        [Required(ErrorMessage = "Please select product.")]
        public long IdProductSelected { get; set; }
        [Required(ErrorMessage = "Please enter client name.")]
        public string ClientName { get; set; }
        [Required(ErrorMessage = "Please enter client email.")]
        public string ClientEmail { get; set; }
        [Required(ErrorMessage = "Please enter mobile number.")]
        public string ClientMobile { get; set; }

        #region Constructors
        public CreateOrderDTO() { }

        public CreateOrderDTO(List<SelectListItem> listProducts)
        {
            Products = listProducts;
        }
        #endregion
    }
}
