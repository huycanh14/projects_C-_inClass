using HelloWorld.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        //Get: /Home/
        public ActionResult Index()
        {
            #region Truyền dữ liệu với ViewBag
            ViewBag.WelcomeString = "Chào mừng bạn với ViewBag";//truyền dữ liệu
            ViewBag.Data = "Data";//truyền dữ liệu
            #endregion

            #region Truyền dư liệu từ Models
            var message = new MessageModel();
            message.Webcome = "Truyền dữ liệu bằng Models";
            #endregion
            return View(message);
        }
    }
}