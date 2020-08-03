using Activity3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Activity3.Controllers
{
    public class CustomerController : Controller
    {

        List<CustomerModel> customers;

        public CustomerController()
        {
            customers = new List<CustomerModel>();
            customers.Add(new CustomerModel(0, "Kurt", 27));
            customers.Add(new CustomerModel(1, "Kathy", 60));
            customers.Add(new CustomerModel(2, "Stan", 58));
            customers.Add(new CustomerModel(3, "Kate", 29));
            customers.Add(new CustomerModel(4, "Alex", 26));
            customers.Add(new CustomerModel(5, "Eli", 27));
        }

        // GET: Customer
        public ActionResult Index()
        {
            return View("~/Views/Home/Index.cshtml");
        }
        public ActionResult Test()
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[0]);
            return View("Test", tuple);
        }
        [HttpPost]
        public PartialViewResult OnSelectCustomer(string CustomerNumber)
        {
            Tuple<List<CustomerModel>, CustomerModel> tuple = new Tuple<List<CustomerModel>, CustomerModel>(customers, customers[Int32.Parse(CustomerNumber)]);
            return PartialView("~/Views/Customer/_CustomerDetails.cshtml", tuple.Item2);
        }
    }
}