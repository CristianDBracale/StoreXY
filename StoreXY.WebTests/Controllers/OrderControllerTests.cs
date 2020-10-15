using StoreXY.Web.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web;
using System.Web.Mvc;

namespace StoreXY.Web.Controllers.Tests
{
    [TestClass]
    public class OrderControllerTests
    {
        [TestMethod]
        public void OrderDetailTest()
        {
            OrderController controller = new OrderController();

            ViewResult result = controller.Index() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ListAllOrdersTest()
        {
            OrderController controller = new OrderController();

            ViewResult result = controller.ListAllOrders() as ViewResult;

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void CreateOrderTest()
        {
            OrderController controller = new OrderController();

            controller.Session["IdClientSelected"] = "2";

            ViewResult result = controller.CreateOrder() as ViewResult;

            Assert.IsNotNull(result);
        }

    }
}