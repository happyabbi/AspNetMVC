﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{

    public class Customer
    {
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public override string ToString()
        {
            return this.CustomerName + "|" + this.Address;
        }
    }


    public class TestController : Controller
    {
        public string GetString()
        {
            return "Hello World is old now. It's time for wassup bro;";
        }

        public Customer GetCustomer()
        {
            Customer c = new Customer();
            c.CustomerName = "Customer 1";
            c.Address = "Address";
            return c;
        }

        [NonAction]
        public string SimpleMothod() {

            return "Hi, I am not action method";
        }
        

        // GET: Test
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult GetView() {
            return View("MyView");
        }

    }
}