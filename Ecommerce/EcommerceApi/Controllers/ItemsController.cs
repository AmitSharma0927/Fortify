using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EcommerceApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceApi.Controllers
{
   
    [ApiController]
    public class ItemsController : ControllerBase
    {
        EcommerceContext ec = new EcommerceContext();
        // POST: api/Items
        [Route("api/AllItems")]
        [HttpGet]
        public List<Items> AllItems()
        {
            List<Items> list = new List<Items>();
            list = ec.Items.ToList();
            return list;
        }
        [Route("api/AddItems")]
        [HttpPost]
        public ActionResult AddItems(Items it)
        {
            ec.Items.Add(it);
            ec.SaveChanges();
            return Ok();
        }
        [Route("api/DeleteItems/{id}")]
        [HttpDelete("{id}")]
        public ActionResult DeleteItems(int id)
        {
            if(id==0)
            {
                return BadRequest();
            }
            else
            {
                Items item = ec.Items.FirstOrDefault(x => x.ItemId == id);
                ec.Remove(item);
                ec.SaveChanges();
                return Ok();
            }
        }

        [Route("api/EditItems")]
        [HttpPost]
        public ActionResult EditItems(Items it)
        {
            ec.Items.Update(it);
            ec.SaveChanges();
            return Ok();
        }

        [Route("api/DetailsItem/{id}")]
        [HttpPost("id")]
        public Items DetailsItem(int id)
        {
            Items item = ec.Items.FirstOrDefault(x => x.ItemId == id);
            return item;
        }
        [Route("api/EditItem")]
        [HttpPost("id")]
        public ActionResult EditItem(Items it)
        {
            ec.Items.Update(it);
            ec.SaveChanges();
            return Ok();
        }

    }
}
