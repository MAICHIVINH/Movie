using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movies_V1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult QuanLyPhim()
        {
            return View();
        }

        public ActionResult QuanLyTaiKhoan()
        {
            return View();
        }

        public ActionResult QuanLyVe()
        {
            return View();
        }
    }
}