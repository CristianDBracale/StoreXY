using StoreXY.DTOs;
using StoreXY.Managers;
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
    }
}
