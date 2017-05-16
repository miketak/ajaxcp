using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxCDP.Models;

namespace AjaxCDP.Controllers
{
    public class AjaxController : Controller
    {
        private static List<Product> _prodList = new List<Product>();

        // GET: Ajax
        public ActionResult Index()
        {
            var p1 = new Product { ProdCode = "P001", ProdName = "Mobile", ProdQty = 75 };
            var p2 = new Product { ProdCode = "P002", ProdName = "Laptop", ProdQty = 125 };
            var p3 = new Product { ProdCode = "P003", ProdName = "Netbook", ProdQty = 100 };
            _prodList.Add(p1);
            _prodList.Add(p2);
            _prodList.Add(p3);

            return View();
        }

        public PartialViewResult ShowDetails()
        {
            System.Threading.Thread.Sleep(3000);
            string code = Request.Form["txtCode"];
            Product prod = new Product();

            foreach (Product p in _prodList)
            {
                if (p.ProdCode == code)
                {
                    prod = p;
                    break;
                }
            }

            return PartialView("_ShowDetails", prod);
        }
    }
}