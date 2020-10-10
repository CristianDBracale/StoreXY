using StoreXY.BusinessModel;
using StoreXY.DTOs;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StoreXY.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "List all orders";

            List<ListOrderDTO> ListOrder = Gateway.GetAllOrders();

            return View("ListAllOrders", ListOrder);
        }

        public ActionResult ListAllOrders()
        {
            ViewBag.Title = "List all orders";

            List<ListOrderDTO> ListOrder = Gateway.GetAllOrders();

            return View("ListAllOrders", ListOrder);
        }
    }
}
