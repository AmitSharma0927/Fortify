using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EcommerceMVC.Models;
using EcommerceMVC.Helper;
using System.Net.Http;

namespace EcommerceMVC.Controllers
{
    public class HomeController : Controller
    {
        ApiHelper hp = new ApiHelper();
        [HttpGet]
        public IActionResult CreateCustomer()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCustomer(CustomerData cd)
        {
            Random rd = new Random();
            cd.Customerid = rd.Next(1, 1000000);
            HttpClient client = hp.Initial();

            var posttask = client.PostAsJsonAsync<CustomerData>("api/Customer", cd);
            //posttask.Wait();

            var result = posttask.Result;
            if(result.IsSuccessStatusCode)
            {
                return RedirectToAction("Error");
            }
            return View();

        }

        [HttpGet]
        public IActionResult CustomerIndex()
        {
            return View();
        }
   
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
