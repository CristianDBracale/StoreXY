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
            ViewBag.Title = "List all orders";

            List<ListOrderDTO> ListOrder = Gateway.GetAllOrders();

            return View("ListAllOrders", ListOrder);
        }

        public ActionResult ListAllOrders()
        {
            try
            {
                ViewBag.Title = "List all orders";
                List<ListOrderDTO> ListOrder = Gateway.GetAllOrders();

                return View("ListAllOrders", ListOrder);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ActionResult CreateOrder()
        {
            if (Session["IdClientSelected"] == null)
            {
                return RedirectToAction(UserController.ActionsUser.ChangeUser.ToString(), ControllerHelpers.UserController, new { type = TypeOfMessageEnum.Error.ToString(), msg = Resources.GetMensage("ErrorMustSelectAClient") });
            }

            try
            {

                return View();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public enum ActionsOrder
        {
            Index,
            ListAllOrders,
            CreateOrder
        }
    }
}
