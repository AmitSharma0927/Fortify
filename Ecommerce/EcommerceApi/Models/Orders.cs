using System;
using System.Collections.Generic;

namespace EcommerceApi.Models
{
    public partial class Orders
    {
        public Orders()
        {
            Catalog = new HashSet<Catalog>();
            Invoice = new HashSet<Invoice>();
        }

        public int OrderId { get; set; }
        public string OrderDesc { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public bool? Isactive { get; set; }
        public int? Customerid { get; set; }

        public Customer Customer { get; set; }
        public ICollection<Catalog> Catalog { get; set; }
        public ICollection<Invoice> Invoice { get; set; }
    }
}
