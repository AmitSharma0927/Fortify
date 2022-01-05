using EcommerceMVC.Helper;
using EcommerceMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace EcommerceMVC.Controllers
{
    public class OrdersMvcController : Controller
    {
        ApiHelper hp = new ApiHelper();
       
        [HttpGet]
        public ActionResult<List<OrderData>> AllOrders()
        {
            try
            {
                List<OrderData> list = new List<OrderData>();
                HttpClient client = hp.Initial();

                var posttask = client.GetAsync("api/AllOrders");
                //posttask.Wait();

                var result = posttask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var res = result.Content.ReadAsStringAsync().Result;
                    list = JsonConvert.DeserializeObject<List<OrderData>>(res);
                }
                //foreach(OrderData li in list)
                //{
                //    if(li.DispatchedDate < DateTime.Now)
                //    {
                //        return View(list);
                //    }

                //}
                 return View(list);
           
            }
            catch(Exception e)
            {
                log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
                log.Error(e.Message);
                return View();
            }
            

        }
        public ActionAsPdf print()
        {
            var q = new ActionAsPdf("AllOrders");
            return q;
        }

    }
}