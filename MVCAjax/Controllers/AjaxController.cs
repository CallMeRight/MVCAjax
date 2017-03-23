using MVCAjax.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAjax.Controllers
{
    public class AjaxController : Controller
    {
        IEnumerable<Product> prodList = new List<Product>
        {
            new Product { ProdCode = "P001", ProdName = "Mobile", ProdQty = 75 },
            new Product { ProdCode = "P002", ProdName = "Laptop", ProdQty = 125 },
            new Product { ProdCode = "P003", ProdName = "Netbook", ProdQty = 100 },
        };
        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult ShowDetails()
        {
            System.Threading.Thread.Sleep(3000);
            string code = Request.Form["txtCode"];
            Product prod = new Product();
            foreach (Product p in prodList)
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