using System;
using System.Collections.Generic;

namespace EcommerceApi.Models
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Orders>();
        }

        public int Customerid { get; set; }
        public string CustomerName { get; set; }
        public string MobileNumber { get; set; }
        public string PostalAdd { get; set; }
        public string EmailId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedDate { get; set; }

        public ICollection<Orders> Orders { get; set; }
    }
}
