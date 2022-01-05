using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class OrderData
    {
        public OrderData()
        {
            Catalog = new HashSet<CatalogData>();
            Invoice = new HashSet<InvoiceData>();
        }

        public int OrderId { get; set; }
        public string OrderDesc { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? DispatchedDate { get; set; }
        public bool? Isactive { get; set; }
        public int? Customerid { get; set; }

        public CustomerData Customer { get; set; }
        public ICollection<CatalogData> Catalog { get; set; }
        public ICollection<InvoiceData> Invoice { get; set; }
    }
}
