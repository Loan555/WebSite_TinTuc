using DuLich.Models.Fun;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DuLich.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public PartialViewResult DanhMucDad()
        {
            var model = new DanhMucDadF().ListAll();
            return PartialView(model);
        }
        [ChildActionOnly]
        public PartialViewResult DanhMuc(long id)
        {
            var model = new DanhMucDadF().ListDanhMuc(id);
            return PartialView(model);
        }
        [HttpPost]
        public ActionResult TimKiem(string search)
        {
            var model = new DanhMucTinF().TimKiem(search);
            return View(model);
        }
        public PartialViewResult TinHot()
        {
            var model = new DanhMucTinF().TinHot(1);
            return PartialView(model);
        }
    }
}