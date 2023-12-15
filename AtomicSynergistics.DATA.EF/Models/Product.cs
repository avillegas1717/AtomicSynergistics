using System;
using System.Collections.Generic;

namespace AtomicSynergistics.DATA.EF.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProducts = new HashSet<OrderProduct>();
            SaleProducts = new HashSet<SaleProduct>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? CostPerUnit { get; set; }
        public decimal? PricePerUnit { get; set; }
        public string? UnitType { get; set; }
        public short? UnitsInStock { get; set; }
        public short? UnitsOnOrder { get; set; }
        public int? ProductStatusId { get; set; }
        public int ProductTypeId { get; set; }
        public int? VendorId { get; set; }
        public string? ProductImage { get; set; }

        public virtual ProductStatus? ProductStatus { get; set; }
        public virtual ProductType? ProductType { get; set; }
        public virtual Vendor? Vendor { get; set; }
        public virtual ICollection<OrderProduct> OrderProducts { get; set; }
        public virtual ICollection<SaleProduct> SaleProducts { get; set; }
    }
}
