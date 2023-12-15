using System;
using System.Collections.Generic;

namespace AtomicSynergistics.DATA.EF.Models
{
    public partial class Country
    {
        public Country()
        {
            Customers = new HashSet<Customer>();
            Locations = new HashSet<Location>();
            Vendors = new HashSet<Vendor>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; } = null!;
        public int? RegionId { get; set; }

        public virtual Region? Region { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Vendor> Vendors { get; set; }
    }
}
