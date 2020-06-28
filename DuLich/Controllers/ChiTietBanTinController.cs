﻿using DuLich.Models.Fun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication_TinTucDuLich.Controllers
{
    public class ChiTietBanTinController : Controller
    {
        // GET: ChiTietBanTin
        public ActionResult Index(long id)
        {
            ViewBag.Tin = new DanhMucTinF().ChiTietTin(id);
            return View(id);
        }
    }
}