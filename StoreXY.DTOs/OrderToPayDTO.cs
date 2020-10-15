using StoreXY.DAL;

namespace StoreXY.DTOs
{
    public class OrderToPayDTO
    {
        public long Id { get; set; }
        public double Price { get; set; }
        public string ProductName { get; set; }

        #region Constructors
        public OrderToPayDTO() { }

        public OrderToPayDTO(Orders order)
        {
            Id = order.id;
            Price = decimal.ToDouble(order.Products1.price);
            ProductName = order.Products1.name;
        }
        #endregion
    }
}
