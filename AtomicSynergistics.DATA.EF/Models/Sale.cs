using System;
using System.Collections.Generic;

namespace AtomicSynergistics.DATA.EF.Models
{
    public partial class Sale
    {
        public Sale()
        {
            SaleProducts = new HashSet<SaleProduct>();
        }

        public int SaleId { get; set; }
        public DateTime SaleDate { get; set; }
        public int SalespersonId { get; set; }
        public int CustomerId { get; set; }
        public decimal? SaleTotal { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Employee? Salesperson { get; set; }
        public virtual ICollection<SaleProduct> SaleProducts { get; set; }
    }
}
