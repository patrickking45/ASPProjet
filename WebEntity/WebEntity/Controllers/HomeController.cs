using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebEntity.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

      /**  public ActionResult Contact()
        {
            using (Models.NorthwndEntities context = new Models.NorthwndEntities())

            {
                var query = from p in context.Products
                            join c in context.Categories on p.CategoryID equals c.CategoryID
                            join s in context.Suppliers on p.SupplierID equals s.SupplierID
                            select p;
                              
                  ViewBag.info = query.ToList();
      
                

            }

            return View();
        }
    */
    
    }
}