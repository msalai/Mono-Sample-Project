using System;
using System.Web.Mvc;
using WebShopMono.Model;
using WebShopMono.Service.Common;
using System.Linq;
using System.Collections.Generic;

namespace WebShopMono.MVC.Controllers
{
    public class WebShopController : Controller
    {
        private IWebShopService service;

        public WebShopController(IWebShopService service)
        {
            this.service = service;
        }

        // GET: WebShop
        public ActionResult Index()
        {
            service.AddProduct(new Product() { Name = "MilkShake", InStock = false, Price = 10, ExpDate = DateTime.Now.AddDays(20) });

            var list =AutoMapper.Mapper.Map<List<Product>>(service.GetAllAvailableProducts());
            return View(list);
        }
    }
}