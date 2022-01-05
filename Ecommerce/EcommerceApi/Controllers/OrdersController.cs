using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rotativa;

namespace EcommerceApi.Controllers
{
   
    [ApiController]
    public class OrdersController : ControllerBase
    {
        EcommerceContext ec = new EcommerceContext();
        // POST: api/Items
       
        [Route("api/AllOrders")]
        [HttpGet]
        public List<Orders> AllOrders()
        {
            List<Orders> list = new List<Orders>();
            list = ec.Orders.Where(x=>x.DispatchedDate<DateTime.Now).ToList();
            return list;
        }
    }
}
