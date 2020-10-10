using StoreXY.DTOs;
using StoreXY.Managers;
using System.Collections.Generic;

namespace StoreXY.BusinessModel
{
    public class Gateway
    {
        public static List<ListOrderDTO> GetAllOrders()
        {
            return OrdersManager.GetAllOrders();
        }
    }
}
