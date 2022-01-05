using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using EcommerceMVC.Helper;
using EcommerceMVC.Models;
using EcommerceMVC.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EcommerceMVC.Controllers
{
    public class ItemsController : Controller
    {
        ApiHelper hp = new ApiHelper();
        [HttpGet]
        public ActionResult<List<ItemsData>> AllItems()
        {
            List<ItemsData> list = new List<ItemsData>();
            HttpClient client = hp.Initial();

            var posttask = client.GetAsync("api/AllItems");
            //posttask.Wait();

            var result = posttask.Result;
            if (result.IsSuccessStatusCode)
            {
                var res = result.Content.ReadAsStringAsync().Result;
                list = JsonConvert.DeserializeObject<List<ItemsData>>(res);
            }
            return View(list);

        }

        [HttpGet]
        public IActionResult CreateItems()
        {
            return View();
        }
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult CreateItems(ItemsData itm)
        {
            Random rd = new Random();
            itm.ItemId = rd.Next(1, 1000000);
            HttpClient client = hp.Initial();

            var posttask = client.PostAsJsonAsync<ItemsData>("api/AddItems", itm);
            //posttask.Wait();

            var result = posttask.Result;
            if (result.IsSuccessStatusCode)
            {
                return RedirectToAction("AllItems");
            }
            return View();
        }

        public IActionResult Delete(int id)
        {
            HttpClient client = hp.Initial();

            var posttask = client.DeleteAsync($"api/DeleteItems/{id}");
            if(posttask.Result.IsSuccessStatusCode)
            {
                return RedirectToAction("AllItems");
            }
            return RedirectToAction("AllItems");
        }
        
        public async Task<IActionResult> EditItem(int id)
        {
            HttpClient client = hp.Initial();
            ItemsData items = new ItemsData();
            var posttask = await client.GetAsync($"api/DetailsItem/{id}");
            //posttask.Wait();

            //var result = posttask.Result;
            if (posttask.IsSuccessStatusCode)
            {
               var res = posttask.Content.ReadAsStringAsync().Result;
                items = JsonConvert.DeserializeObject<ItemsData>(res);
            }
            return View(items);
        }
        [HttpPost]
        public async Task<IActionResult> EditItem(ItemsData it)
        {
            HttpClient client = hp.Initial();
            ItemsData items = new ItemsData();
            var posttask = await client.PostAsJsonAsync<ItemsData>("api/EditItem",it);
            //posttask.Wait();

            //var result = posttask.Result;
            if (posttask.IsSuccessStatusCode)
            {
                return RedirectToAction("AllItems");
            }
            return RedirectToAction("AllItems");
        }

        
    }
}