using System;
using System.Collections.Generic;

namespace EcommerceApi.Models
{
    public partial class Items
    {
        public Items()
        {
            Catalog = new HashSet<Catalog>();
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

        public Category Category { get; set; }
        public ICollection<Catalog> Catalog { get; set; }
    }
}
