using System;
using System.Collections.Generic;

namespace EcommerceApi.Models
{
    public partial class Category
    {
        public Category()
        {
            Items = new HashSet<Items>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Description { get; set; }
        public bool? IsActive { get; set; }

        public ICollection<Items> Items { get; set; }
    }
}
