using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class ItemsData
    {
        public ItemsData()
        {
            Catalog = new HashSet<CatalogData>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public int? CategoryId { get; set; }
        public int? ItemPrice { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool? IsActive { get; set; }
        public int? TotalQty { get; set; }

        public CategoryData Category { get; set; }
        public ICollection<CatalogData> Catalog { get; set; }
    }
}
