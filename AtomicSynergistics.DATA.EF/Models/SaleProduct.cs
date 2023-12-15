using System;
using System.Collections.Generic;

namespace AtomicSynergistics.DATA.EF.Models
{
    public partial class SaleProduct
    {
        public int SaleProductId { get; set; }
        public int SaleId { get; set; }
        public int ProductId { get; set; }
        public short SaleQuantity { get; set; }

        public virtual Product? Product { get; set; }
        public virtual Sale? Sale { get; set; }
    }
}
