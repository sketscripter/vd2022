using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vd2022.Models;

namespace Vd2022.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer{Id=1,Name ="Will Smith"},
                new Customer{Id=2,Name ="Pascal Blaise"}
            };

            ViewBag.CustomersList = customers;
            return View();
        }

        public ActionResult Detail(int id)
        {
            var customers = new List<Customer>
            {
                new Customer{Id=1,Name ="Will Smith"},
                new Customer{Id=2,Name ="Pascal Blaise"}
            };
            ViewBag.CustomerDetail = customers.ElementAt(id - 1);
            return View();
        }
    }
}