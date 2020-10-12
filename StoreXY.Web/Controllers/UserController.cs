using StoreXY.BusinessModel;
using StoreXY.DTOs;
using StoreXY.ResourcesManager;
using StoreXY.Web.Enums;
using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace StoreXY.Web.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Index(string type, string msg)
        {
            List<SelectUserDTO> selectUserDTO = Gateway.GetAllUsers();
            if (!string.IsNullOrWhiteSpace(msg))
            {
                ViewBag.Msg = msg;
            }
            return View(selectUserDTO);
        }

        public ActionResult ChangeUser(SelectUserDTO selectUserDTO)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(selectUserDTO.SelectedClient))
                {
                    return RedirectToAction(ActionsUser.Index.ToString(), new { type = TypeOfMessageEnum.Error.ToString(), msg = Resources.GetMensage("ErrorMustSelectAClient") });
                }

                Session["IdClientSelected"] = long.Parse(selectUserDTO.SelectedClient);

                return RedirectToAction(ActionsUser.Index.ToString(), new { type = TypeOfMessageEnum.Success.ToString(), msg = Resources.GetMensage("SuccessfullyChangedClient") });
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public enum ActionsUser
        {
            Index,
            ChangeUser
        }
    }
}