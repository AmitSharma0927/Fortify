using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class CategoryData
    {
        public CategoryData()
        {
            Items = new HashSet<ItemsData>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<ItemsData> Items { get; set; }
    }
}
