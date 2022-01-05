using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class CatalogData
    {
        public int CatalogId { get; set; }
        public int? OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? ItemQty { get; set; }
        public string Description { get; set; }

        public ItemsData Item { get; set; }
        public OrderData Order { get; set; }
    }
}
