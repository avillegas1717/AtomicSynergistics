using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AtomicSynergistics.DATA.EF.Models
{
    public class CountriesMetadata
    {
        //Auto Incremented
        public int CountryID { get; set; }

        [Required(ErrorMessage = "Country name is required")]
        [StringLength(100, ErrorMessage = "Must not exceed 100 characters.")]
        [Display(Name = "Country Name")]
        public string CountryName { get; set; } = null!;

        public int RegionID { get; set; }
    }

    public class CustomersMetadata
    {
        public int CustomerID { get; set; }
        [Required(ErrorMessage = "Customer name is required")]
        [StringLength(150, ErrorMessage = "Must not exceed 150 characters.")]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; } = null!;
        [Required(ErrorMessage = "Contact name is required")]
        [StringLength(75, ErrorMessage = "Must not exceed 75 characters.")]
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; } = null!;
        [Required(ErrorMessage = "Contact Phone Number is required")]
        [StringLength(20, ErrorMessage = "Must not exceed 20 characters.")]
        [Display(Name = "Contact Phone Number")]
        public string ContactPhone { get; set; } = null!;
        [Required(ErrorMessage = "Contact Email is required")]
        [StringLength(100, ErrorMessage = "Must not exceed 100 characters.")]
        [Display(Name = "Contact Email Address")]
        public string ContactEmail { get; set; } = null!;
        [Required(ErrorMessage = "Billing Address is required")]
        [StringLength(100, ErrorMessage = "Must not exceed 100 characters.")]
        [Display(Name = "Billing Address")]
        public string BillingAddress { get; set; } = null!;
        [Required(ErrorMessage = "Billing City is required")]
        [StringLength(100, ErrorMessage = "Must not exceed 100 characters.")]
        [Display(Name = "Billing City Address")]
        public string BillingCity { get; set;} = null!;
        [StringLength(2, ErrorMessage = "Only use 2 characters.")]
        [Display(Name = "Billing State")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string BillingState { get; set;}
        [Required(ErrorMessage = "Postal Code is required")]
        [StringLength(10, ErrorMessage = "Must not exceed 10 characters.")]
        [Display(Name = "Billing Postal Code")]
        public string BillingPostalCode { get;} = null!;

        public int CountryID { get; set;}
    }

    public class DepartmentsMetadata
    {
        public int DepartmentID { get; set; }
        [Required(ErrorMessage = "Department Name is required")]
        [StringLength(150, ErrorMessage = "Must not exceed 150 characters.")]
        [Display(Name = "Department Name")]
        public string DepartmentName { get; set; } = null!;

        public int LocationID { get; set; }
    }

    public class EmployeesMetadata
    {
        public int EmployeeId { get; set; }

        [Required(ErrorMessage ="*First Name Required")]
        [StringLength(25, ErrorMessage ="Maximum 25 characters")]
        [Display(Name ="First Name")]
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "*Last Name Required")]
        [StringLength(50, ErrorMessage = "Maximum 50 characters")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        [Display(Name ="Name")]
        public string FullName { get; }
        [StringLength(100, ErrorMessage = "Maximum 100 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? Position { get; set; }
        [DataType(DataType.Currency)]
        [DisplayFormat(NullDisplayText = "N/A")]
        public decimal? Salary { get; set; }
        [Display(Name = "Hire Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "N/A")]
        public DateTime? HireDate { get; set; }
        [Display(Name = "Termination Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(NullDisplayText = "N/A")]
        public DateTime? TerminationDate { get; set; }
        [StringLength(100, ErrorMessage = "Maximum 100 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? Address { get; set; }
        [StringLength(100, ErrorMessage = "Maximum 100 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? City { get; set; }
        [StringLength(2, ErrorMessage = "Maximum 2 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? State { get; set; }
        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        [Display(Name = "Zip Code")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? PostalCode { get; set; }
        [Display(Name = "Country")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int? CountryId { get; set; }
        [StringLength(100, ErrorMessage = "Maximum 100 characters")]
        [DataType(DataType.EmailAddress)]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? Email { get; set; }
        [StringLength(20, ErrorMessage = "Maximum 20 characters")]
        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "*Department Required")]
        [Display(Name = "Department")]
        public int DepartmentId { get; set; }
        [Display(Name = "Manager")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int? ManagerId { get; set; }

    }

    public class LocationsMetadata
    {
        public int LocationId { get; set; }
        [Required(ErrorMessage = "*Address Required")]
        [Display(Name ="Address")]
        [StringLength(100, ErrorMessage = "Maximum 100 characters")]
        public string LocationAddress { get; set; } = null!;
        [Required(ErrorMessage = "*City Required")]
        [Display(Name = "City")]
        [StringLength(100, ErrorMessage = "Maximum 100 characters")]
        public string LocationCity { get; set; } = null!;
        [Display(Name = "State")]
        [StringLength(2, ErrorMessage = "Maximum 2 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? LocationState { get; set; }
        [Display(Name = "Zip Code")]
        [StringLength(10, ErrorMessage = "Maximum 10 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? LocationPostalCode { get; set; }
        [Display(Name = "Country")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int? CountryId { get; set; }
    }

    public class OrderProductsMetadata
    {
        public int OrderProductId { get; set; }
        [Required(ErrorMessage = "*Order Required")]
        [Display(Name ="Order")]
        public int OrderId { get; set; }
        [Required(ErrorMessage = "*Product Required")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        [Required(ErrorMessage = "*Order Qty Required")]
        [Display(Name = "Order Qty")]
        public short OrderQuantity { get; set; }

    }

    public class OrdersMetadata
    {
        public int OrderId { get; set; }

        [Display(Name = "PO")]
        [StringLength(50, ErrorMessage = "Cannot exceed 50 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? Ponumber { get; set; }

        [Required]
        [Display(Name = "Vendor")]
        public int VendorId { get; set; }

        [Required]
        [Display(Name = "Order Date")]
        [DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime OrderDate { get; set; }

        [Display(Name = "Total")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false, NullDisplayText = "N/A")]
        public decimal? OrderTotal { get; set; }
    }

    public class ProductsMetadata
    {
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(150, ErrorMessage ="Must not exceed 150 characters")]
        public string ProductName { get; set; } = null!;

        [DataType(DataType.MultilineText)]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? Description { get; set; }

        [Display(Name = "Cost/Unit")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal? CostPerUnit { get; set; }

        [Display(Name = "Price/Unit")]
        [DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
        public decimal? PricePerUnit { get; set; }

        [Display(Name = "Unit Type")]
        [StringLength(50, ErrorMessage = "Must not exceed 50 characters")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? UnitType { get; set; }

        [Display(Name = "On Hand")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public short? UnitsInStock { get; set; }

        [Display(Name = "On Order")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public short? UnitsOnOrder { get; set; }

        [Display(Name = "Status ID")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int? ProductStatusId { get; set; }

        [Required]
        [Display(Name = "Product Type ID")]
        public int ProductTypeId { get; set; }

        [Display(Name = "Vendor ID")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public int? VendorId { get; set; }

        [Display(Name = "Image")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? ProductImage { get; set; }
    }

    public class ProductStatusesMetadata
    {
        public int ProductStatusId { get; set; }

        [Required]
        [Display(Name = "Product Status")]
        [StringLength(100, ErrorMessage = "Must not exceed 100 characters")]
        public string ProductStatusName { get; set; } = null!;
    }

    public class ProductTypesMetadata
    {
        public int ProductTypeId { get; set; }

        [Required]
        [Display(Name = "Product Type")]
        [StringLength(150, ErrorMessage = "Must not exceed 150 characters")]
        public string ProductTypeName { get; set; } = null!;
    }
  
    public class RegionsMetadata
    {
        [Required]
        public int RegionId { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Region")]
        public string RegionName { get; set; } = null!;
    }

    public class SaleProductsMetadata
    {
        [Required]
        [Display(Name = "Sale Product")]
        public int SaleProductId { get; set; }
        [Required]
        [Display(Name = "Sale")]
        public int SaleId { get; set; }
        [Required]
        [Display(Name = "Product")]
        public int ProductId { get; set; }
        [Required]
        [Display(Name ="Quantity")]
        public short SaleQuantity { get; set; }
    }

    public class SalesMetadata
    {
        [Required]
        [Display(Name = "Sale")]
        public int SaleId { get; set; }
        [Required]
        [Display(Name ="Sale Date")]
        [DataType(DataType.Date)]
        public DateTime SaleDate { get; set; }
        [Required]
        [Display(Name = "Salesperson")]
        public int SalespersonId { get; set; }
        [Required]
        [Display(Name = "Customer")]
        public int CustomerId { get; set; }
        [DataType(DataType.Currency)]
        [Display(Name ="Sale Total")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public decimal? SaleTotal { get; set; }
    }

    public class VendorsMetadata
    {
        [Required]
        public int VendorId { get; set; }
        [Required]
        [StringLength(150)]
        [Display (Name="Vendor")]
        public string VendorName { get; set; } = null!;
        [Required]
        [StringLength(75)]
        [Display(Name ="Vendor Contact")]
        public string VendorContact { get; set; } = null!;
        [Required]
        [StringLength(20)]
        [DataType(DataType.PhoneNumber)]
        [Display(Name="Phone Number")]
        public string VendorPhone { get; set; } = null!;
        [Required]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string VendorEmail { get; set; } = null!;
        [Required]
        [StringLength(100)]
        [Display(Name = "Address")]
        public string VendorAddress { get; set; } = null!;
        [Required]
        [StringLength(100)]
        [Display(Name = "City")]
        public string VendorCity { get; set; } = null!;
        [StringLength(2)]
        [Display(Name ="State")]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? VendorState { get; set; }
        [StringLength(10)]
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        [DisplayFormat(NullDisplayText = "N/A")]
        public string? VendorPostalCode { get; set; }
        [Required]
        public int CountryId { get; set; }
    }
}
