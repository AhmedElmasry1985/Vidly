using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private readonly List<Customer> _customers = new List<Customer>
        {
            new Customer {Id = 1, Name = "John Doe"},
            new Customer {Id = 2, Name = "Jean Doe"}
        };
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new CustomersViewModel
            {
                Customers = _customers
            };
            return View(customers);
        }

        public ActionResult Details(int? id)
        {
            var customer = _customers.FirstOrDefault(c => c.Id == id);
            if (customer == null)
                return HttpNotFound($"Customer with id {id} is not found!");
            return View(customer);
        }
    }
}