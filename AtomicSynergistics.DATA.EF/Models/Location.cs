using System;
using System.Collections.Generic;

namespace AtomicSynergistics.DATA.EF.Models
{
    public partial class Location
    {
        public Location()
        {
            Departments = new HashSet<Department>();
        }

        public int LocationId { get; set; }
        public string LocationAddress { get; set; } = null!;
        public string LocationCity { get; set; } = null!;
        public string? LocationState { get; set; }
        public string? LocationPostalCode { get; set; }
        public int? CountryId { get; set; }

        public virtual Country? Country { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
    }
}
