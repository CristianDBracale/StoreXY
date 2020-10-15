using StoreXY.DTOs;
using StoreXY.Managers;
using System;
using System.Collections.Generic;

namespace StoreXY.BusinessModel
{
    public class Gateway
    {
        #region Orders
        public static List<ListOrderDTO> GetAllOrders()
        {
            return OrdersManager.GetAllOrders();
        }

        public static void SaveNewOrder(CreateOrderDTO createOrderDTO, long idClientSelected)
        {
            OrdersManager.SaveNewOrder(createOrderDTO, idClientSelected);
        }

        public static OrderDetailDTO GetOrderById(long idOrder)
        {
            return OrdersManager.GetOrderById(idOrder);
        }

        public static OrderToPayDTO GetOrderToPayById(long idOrder)
        {
            return OrdersManager.GetOrderToPayById(idOrder);
        }

        #endregion

        #region Clients
        public static List<SelectUserDTO> GetAllUsers()
        {
            return UsersManager.GetAllUsers();
        }

        public static SelectUserDTO GetUserById(long id)
        {
            return UsersManager.GetUserById(id);
        }
        #endregion

        #region Products
        public static List<ListProductDTO> GetAllProducts()
        {
            return ProductManager.GetAllProducts();
        }
        #endregion

        #region API orders
        public static void UpdateOrder(long id, string newState)
        {
            OrdersManager.UpdateOrder(id, newState);
        }
        #endregion
    }
}
