using System;
using System.Collections.Generic;

namespace EcommerceApi.Models
{
    public partial class Catalog
    {
        public int CatalogId { get; set; }
        public int? OrderId { get; set; }
        public int? ItemId { get; set; }
        public int? ItemQty { get; set; }
        public string Description { get; set; }

        public Items Item { get; set; }
        public Orders Order { get; set; }
    }
}
