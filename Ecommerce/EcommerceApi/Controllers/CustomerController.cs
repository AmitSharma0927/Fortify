using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        EcommerceContext ec = new EcommerceContext();
        // GET api/values
        [HttpPost]
        public ActionResult CreateCustomer(Customer cs)
        {
            ec.Customer.Add(cs);
            ec.SaveChanges();
            return Ok();
        }
    }
}
