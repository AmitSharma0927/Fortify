using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EcommerceMVC.Models
{
    public class CustomerData
    {
        public CustomerData()
        {
            Orders = new HashSet<OrderData>();
        }

        public int Customerid { get; set; }
        [Required]
        [Display(Name ="Name")]
        public string CustomerName { get; set; }
        [Required]
        [Display(Name = "Mobile-Number")]
        public string MobileNumber { get; set; }
        [Required]
        [Display(Name = "Address")]
        public string PostalAdd { get; set; }
        [Required]
        [Display(Name = "Email")]
        public string EmailId { get; set; }
        [Required]
        [Display(Name = "Active")]
        public bool? IsActive { get; set; }
        [Required]
        [Display(Name = "Create Date")]
        public DateTime? CreatedDate { get; set; }

        public ICollection<OrderData> Orders { get; set; }
    }
}
   

