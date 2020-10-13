using StoreXY.DAL;

namespace StoreXY.DTOs
{
    public class ListProductDTO
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        #region Constructors
        public ListProductDTO() { }

        public ListProductDTO(Products product)
        {
            Id = product.id;
            Name = product.name;
            Price = product.price;
        }

        #endregion
    }
}
