using StoreXY.APIPlaceToPay;
using StoreXY.BusinessModel;
using StoreXY.DTOs;
using StoreXY.ResourcesManager;
using StoreXY.Web.Enums;
using StoreXY.Web.Helpers;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StoreXY.Web.Controllers
{
    public class OrderController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = Resources.GetMessage("ListAllOrders");

            List<ListOrderDTO> ListOrder = Gateway.GetAllOrders();

            return View(ActionsOrder.ListAllOrders.ToString(), ListOrder);
        }

        public ActionResult ListAllOrders()
        {
            try
            {
                ViewBag.Title = Resources.GetMessage("ListAllOrders");
                List<ListOrderDTO> ListOrder = Gateway.GetAllOrders();

                return View(ActionsOrder.ListAllOrders.ToString(), ListOrder);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpGet]
        public ActionResult CreateOrder()
        {
            if (Session["IdClientSelected"] == null)
            {
                return RedirectToAction(UserController.ActionsUser.ChangeUser.ToString(), ControllerHelpers.UserController, new { type = TypeOfMessageEnum.Error.ToString(), msg = Resources.GetMessage("ErrorMustSelectAClient") });
            }

            try
            {
                List<SelectListItem> listProducts = new List<SelectListItem>();
                foreach (var product in Gateway.GetAllProducts())
                {
                    listProducts.Add(new SelectListItem() { Text = product.Name, Value = product.Id.ToString() });
                }
                CreateOrderDTO createOrderDTO = new CreateOrderDTO(listProducts);

                return View(createOrderDTO);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public ActionResult SaveNewOrder(CreateOrderDTO createOrderDTO)
        {
            if(!ModelState.IsValid)
            {
                List<SelectListItem> listProducts = new List<SelectListItem>();
                foreach (var product in Gateway.GetAllProducts())
                {
                    listProducts.Add(new SelectListItem() { Text = product.Name, Value = product.Id.ToString() });
                }
                createOrderDTO.Products = listProducts;
                return View(ActionsOrder.CreateOrder.ToString(),createOrderDTO);
            }

            try
            {
                Gateway.SaveNewOrder(createOrderDTO, (long)Session["IdClientSelected"]);

                return RedirectToAction(ActionsOrder.Index.ToString());
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ActionResult OrderDetail(long idOrder)
        {
            OrderDetailDTO orderDetail = Gateway.GetOrderById(idOrder);

            return View(orderDetail);
        }

        public ActionResult PayOrder(long idOrder)
        {
            OrderToPayDTO orderToPayDTO = Gateway.GetOrderToPayById(idOrder);

            PlaceToPay APIPlaceToPay = new PlaceToPay();

            APIPlaceToPay.Pay(orderToPayDTO);

            return RedirectToAction(ActionsOrder.Index.ToString());
        }

        #region Enums

        public enum ActionsOrder
        {
            Index,
            ListAllOrders,
            CreateOrder,
            SaveNewOrder,
            OrderDetail,
            PayOrder
        }

        #endregion
    }
}
