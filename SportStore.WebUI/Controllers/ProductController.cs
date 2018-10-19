using SportStore.Domain.Abstract;
using SportStore.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SportStore.WebUI.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository rep;
        public ProductController(IProductRepository _rep) {
            rep = _rep;
        }
        // GET: Product
        public ViewResult List()
        {
            //1
            //return View();

            //2
            /*IQueryable<Product> products =
                new List<Product>() {
                    new Product() {Name = "N1", Price = 10 }
                    , new Product() {Name = "N2", Price = 50 }
                    , new Product() {Name = "N3", Price = 5 }
                }.AsQueryable();
            return View(products);*/

            //3
            //return View(rep.Products);
            return View(rep.Products.ToList());
        }
    }
}