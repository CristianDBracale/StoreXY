using StoreXY.DAL;
using StoreXY.DTOs;
using System.Collections.Generic;

namespace StoreXY.Managers
{
    public class ProductManager
    {
        /// <summary>
        /// Method that returns all productss
        /// </summary>
        /// <returns>List<ListProductDTO></returns>
        public static List<ListProductDTO> GetAllProducts()
        {
            List<ListProductDTO> ListProductDTOs = new List<ListProductDTO>();
            using (StoreXYEntities db = new StoreXYEntities())
            {
                foreach (Products product in db.Products)
                {
                    ListProductDTOs.Add(new ListProductDTO(product));
                }
            }
            return ListProductDTOs;
        }
    }
}
