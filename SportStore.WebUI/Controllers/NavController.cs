using SportStore.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.WebUI.Controllers
{
    public class NavController : Controller
    {
        private IProductRepository rep;
        public NavController(IProductRepository _rep)
        {
            rep = _rep;
        }

        // GET: Nav
        /*public string Menu()
        {
            return "Hello from NavController";
        }*/

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.CurrentCategory = category;
            return PartialView(
                rep.Products
                    .Select(p => p.Category)
                    .Distinct()
                    .OrderBy(c => c)
                );
        }
    }
}