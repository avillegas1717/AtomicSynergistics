using System;
using System.Collections.Generic;

namespace AtomicSynergistics.DATA.EF.Models
{
    public partial class Vendor
    {
        public Vendor()
        {
            Orders = new HashSet<Order>();
            Products = new HashSet<Product>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; } = null!;
        public string VendorContact { get; set; } = null!;
        public string VendorPhone { get; set; } = null!;
        public string VendorEmail { get; set; } = null!;
        public string VendorAddress { get; set; } = null!;
        public string VendorCity { get; set; } = null!;
        public string? VendorState { get; set; }
        public string? VendorPostalCode { get; set; }
        public int CountryId { get; set; }

        public virtual Country? Country { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
