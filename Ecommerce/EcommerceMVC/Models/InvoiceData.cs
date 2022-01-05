using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public partial class InvoiceData
    {
        public int InvoiceId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? Amount { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }

        public OrderData Order { get; set; }
    }
}
