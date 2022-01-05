using System;
using System.Collections.Generic;

namespace EcommerceApi.Models
{
    public partial class Invoice
    {
        public int InvoiceId { get; set; }
        public int? OrderId { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int? Amount { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }

        public Orders Order { get; set; }
    }
}
