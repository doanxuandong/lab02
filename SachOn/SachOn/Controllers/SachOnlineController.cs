﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SachOn.Models;

namespace SachOn.Controllers
{
    public class SachOnlineController : Controller
    {
        // GET: SachOnline
        dbSachOnlineDataContext data = new dbSachOnlineDataContext();
        private List<Sach> LaySachMoi(int count)
        {
            return data.Saches.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }
        public ActionResult Index()
        {
            var ListSachMoi = LaySachMoi(6);
            return View(ListSachMoi);
        }
        public ActionResult ChuDePartial()
        {
            var listChuDe = from cd in data.CHUDEs select cd;
            return PartialView(listChuDe);
        }
    }
}