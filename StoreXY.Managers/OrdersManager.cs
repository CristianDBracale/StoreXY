using StoreXY.DAL;
using StoreXY.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public static void SaveNewOrder(CreateOrderDTO createOrderDTO, long idClientSelected)
        {
            Orders order = new Orders
            {
                customer_name = createOrderDTO.ClientName,
                customer_email = createOrderDTO.ClientEmail,
                customer_mobile = createOrderDTO.ClientMobile,
                status = "CREATED",
                created_at = DateTime.Now,
                idClient = idClientSelected,
                idProduct = createOrderDTO.IdProductSelected
            };

            using (StoreXYEntities db = new StoreXYEntities())
            {
                db.Orders.Add(order);
                db.SaveChanges();
            }
        }

        public static OrderToPayDTO GetOrderToPayById(long idOrder)
        {
            try
            {
                Orders order;
                OrderToPayDTO orderToPayDTO;
                using (StoreXYEntities db = new StoreXYEntities())
                {
                    order = db.Orders.FirstOrDefault(x => x.id == idOrder);
                    orderToPayDTO = new OrderToPayDTO(order);
                }

                return orderToPayDTO;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public static OrderDetailDTO GetOrderById(long idOrder)
        {
            try
            {
                Orders order;
                OrderDetailDTO orderDetailDTO;
                using (StoreXYEntities db = new StoreXYEntities())
                {
                    order = db.Orders.FirstOrDefault(x => x.id == idOrder);
                    orderDetailDTO = new OrderDetailDTO(order);
                }

                return orderDetailDTO;
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public static void UpdateOrder(long id, string newState)
        {
            try
            {
                using (StoreXYEntities db = new StoreXYEntities())
                {
                    Orders order = db.Orders.FirstOrDefault(x => x.id == id);
                    order.status = newState;
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
