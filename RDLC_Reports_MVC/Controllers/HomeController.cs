using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RDLC_Reports_MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            NorthwindEntities entities = new NorthwindEntities();
            return View(from customer in entities.Customers.Take(10)
                        select customer);
        }
    }
}