using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment.Controllers
{
    public class AssignmentController : Controller
    {
        // GET: Assignment
        NorthwindEntities ne=new NorthwindEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCusomfromGermany()
        {
            IEnumerable e=from c in ne.Customers
                          where c.Country=="Germany"
                          select c;
            return View(e);
        }
        public ActionResult GetCustomUsingOrder()
        {
            IEnumerable vs=from c in ne.Customers
                           join c2 in ne.Orders
                           on c.CustomerID equals c2.CustomerID
                           where c2.OrderID==10248
                           select c;
            return View(vs);

        }
    }
}