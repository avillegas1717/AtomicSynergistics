using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AtomicSynergistics.DATA.EF.Models
{
    [ModelMetadataType(typeof(CountriesMetadata))]
    public partial class Country
    {

    }

    [ModelMetadataType(typeof(CustomersMetadata))]
    public partial class Customer
    {

    }

    [ModelMetadataType(typeof(DepartmentsMetadata))]
    public partial class Department
    {

    }

    [ModelMetadataType(typeof(EmployeesMetadata))]
    public partial class Employee
    {
        public string? FullName
        {
            get
            {
                return string.Format($"{FirstName} {LastName}");
            }
        }

    }

    [ModelMetadataType(typeof(LocationsMetadata))]
    public partial class Location
    {
        public string? Branch
        {
            get
            {
                return string.Format($"{LocationCity} Branch");
            }
        }

    }

    [ModelMetadataType(typeof(OrderProductsMetadata))]
    public partial class OrderProduct
    {

    }

    [ModelMetadataType(typeof(OrdersMetadata))]
    public partial class Order
    {

    }

    [ModelMetadataType(typeof(ProductsMetadata))]
    public partial class Product
    {

    }

    [ModelMetadataType(typeof(ProductStatusesMetadata))]
    public partial class ProductStatus
    {

    }

    [ModelMetadataType(typeof(ProductTypesMetadata))]
    public partial class ProductType
    {

    }

    [ModelMetadataType(typeof(RegionsMetadata))]
    public partial class Region
    {

    }

    [ModelMetadataType(typeof(SaleProductsMetadata))]
    public partial class SaleProduct
    {

    }

    [ModelMetadataType(typeof(SalesMetadata))]
    public partial class Sale
    {
        
    }

    [ModelMetadataType(typeof(VendorsMetadata))]
    public partial class Vendor
    {

    }
}