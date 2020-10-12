using StoreXY.DAL;
using StoreXY.DTOs;
using System.Collections.Generic;

namespace StoreXY.Managers
{
    public class OrdersManager
    {
        /// <summary>
        /// Method that returns all orders
        /// </summary>
        /// <returns>List<ListOrderDTO></returns>
        public static List<ListOrderDTO> GetAllOrders()
        {
            List<ListOrderDTO> listOrderDTOs = new List<ListOrderDTO>();
            using (StoreXYEntities db = new StoreXYEntities())
            {
                foreach (Orders order in db.Orders)
                {
                    listOrderDTOs.Add(new ListOrderDTO(order));
                }
            }
            return listOrderDTOs;
        }
    }
}
