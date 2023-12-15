using Microsoft.AspNetCore.Mvc;
using AtomicSynergistics.DATA.EF.Models;
using ChartJSCore; //Added for use
using ChartJSCore.Models;
using ChartJSCore.Helpers;
using ChartJSCore.Plugins.Zoom;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace AtomicSynergistics.UI.MVC.Controllers
{
    public class ChartsController : Controller
    {
        // Created a field to store context info
        private readonly AtomicContext _context;

        // Updated Charts constructor to accept the context data
        public ChartsController(AtomicContext context)
        {
            // Assign the context data to the field
            _context = context;
        }

        public IActionResult Index()
        {
            // Linq statements for retrieving the data we want from our database
            var salesData = _context.Sales
                .Include(s => s.Customer)
                .Include(s => s.Customer.Country)
                .Include(s => s.Customer.Country.Region)
                .Include(s => s.Salesperson)
                .Where(s => s.SaleDate.Year == 2022)
                .OrderBy(s => s.SaleDate)
                .ToList();

            // Group salesData by month and calculate the sum of SaleTotals for each month
            // Y Axis (Sales)
            List<double?> monthlySales = salesData.GroupBy(sale => new { sale.SaleDate.Year, sale.SaleDate.Month })
                        .Select(group => 
                            group.Sum(sale => sale.SaleTotal))
                        .Select(totalSales => (double?)totalSales).ToList(); // Convert decimal to

            // Retrieve the distinct, abbreviated month names present in the data
            // X Axis (Month)
            List<string> monthNames = salesData
                                        .Select(s => s.SaleDate.ToString("MMM"))
                                        .Distinct()
                                        .ToList();

            // Construct the Chart object
            Chart salesLineChart = new Chart();

            // Assign the type using the enum
            salesLineChart.Type = Enums.ChartType.Line;

            //Create the chart Data object
            ChartJSCore.Models.Data lineChartData = new ChartJSCore.Models.Data();

            // Assign the month names to the label
            lineChartData.Labels = monthNames;

            // Create the LineDataset object and assign values
            salesLineChart.Options.Scales = new Dictionary<string, Scale>();
            CartesianScale xAxis = new CartesianScale();
            xAxis.Display = true;
            xAxis.Title = new Title
            {
                Text = new List<string> { "Month" },
                Display = true
            };
            salesLineChart.Options.Scales.Add("x", xAxis);

            LineDataset lineDataset = new LineDataset()
            {
                Label = "Revenue",
                Data = monthlySales,
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgb(69, 85, 21)
                },
                BorderColor = new List<ChartColor>
                {
                    ChartColor.FromRgb(69, 85, 21)
                },
                BorderWidth = new List<int>() { 1 },
                Fill = "false",
                Tension = .25,
                BorderCapStyle = "butt"

            };

            lineChartData.Datasets = new List<Dataset> { lineDataset };

            salesLineChart.Data = lineChartData;

            ViewData["lineChart"] = salesLineChart;


            #region Sales by Salesperson Bar Chart

            ///// Sales by Salesperson Bar Chart /////

            // Group salesData by salesperson and calculate the sum of SaleTotals for each salesperson.
            // Their name is the Key and their total sales is the Value.
            Dictionary<string, double?> totalSalesBySalesperson = salesData
                .GroupBy(sale => sale.Salesperson.FullName)
                .ToDictionary(
                    group => group.Key,
                    group => (double?)group.Sum(sale => sale.SaleTotal));

            //List to store the salesperson names
            List<string> salesPersonFullNames = new List<string>();

            //List to store their total sales
            List<double?> salesPersonTotalSales = new List<double?>();

            //Loop through the dictionary
            foreach (var item in totalSalesBySalesperson)
            {
                //For each item in the dictionary, populate the list
                salesPersonFullNames.Add(item.Key);
                salesPersonTotalSales.Add(item.Value);
            }

            //Create the Chart object
            Chart salesBarChart = new Chart();

            //Assign the type using the enum
            salesBarChart.Type = Enums.ChartType.Bar;

            //Create the chart Data object
            ChartJSCore.Models.Data barChartData = new ChartJSCore.Models.Data();

            //Assign the salesperson names to the labels
            barChartData.Labels = salesPersonFullNames;

            //Create the BarDataset object and assign values
            BarDataset barDataset = new BarDataset()
            {
                Label = "Sales",
                Data = salesPersonTotalSales,
                BackgroundColor = new List<ChartColor>
                {
                    ChartColor.FromRgb(69, 85, 21)
                },
                BorderColor = new List<ChartColor>
                {
                    ChartColor.FromRgb(69, 85, 21)
                },
                BorderWidth = new List<int>() { 1 },
                BarPercentage = 1,
                BarThickness = 20,
                MaxBarThickness = 30,
                MinBarLength = 2
            };

            //Create a List<Dataset> to store the Chart data
            barChartData.Datasets = new List<Dataset>();

            //Add the customized BarDataset to the list
            barChartData.Datasets.Add(barDataset);

            //Assign the List<Dataset> to the Data property of the Chart object
            salesBarChart.Data = barChartData;

            //Create and customize formatting options to be used with out chart
            var options = new Options
            {
                Responsive = true,
                MaintainAspectRatio = false
            };

            //Store the completed chart in the ViewData
            ViewData["BarChart"] = salesBarChart;
            #endregion


            return View();
        }
    }
}
