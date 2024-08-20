using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using ScottPlot.Plottables;
using ScottPlot;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Models
{
    public class ChartService
    {
        //public static async Task<string> GeneratePieChartImageAsync(List<Employee> employees)
        //{
        //    var plotModel = new PlotModel { Title = "Total Time Worked by Employees" };
        //    var pieSeries = new PieSeries
        //    {
        //        StrokeThickness = 1,
        //        Diameter = 0.8,
        //        InsideLabelPosition = 0.6
        //    };

        //    foreach (var employee in employees)
        //    {
        //        pieSeries.Slices.Add(new OxyPlot.Series.PieSlice(employee.EmployeeName, employee.TotalTimeWorked)
        //        {
        //            IsExploded = employee.TotalTimeWorked < 100, // Optional: Highlight slices based on conditions
        //            Fill = OxyColors.SkyBlue // Optional: Customize colors
        //        });
        //    }

        //    plotModel.Series.Add(pieSeries);
        //    plotModel.Axes.Add(new CategoryAxis
        //    {
        //        Position = AxisPosition.Left,
        //        Key = "CategoryAxis",
        //        Title = "Employee Names"
        //    });

        //    using (var stream = new MemoryStream())
        //    {
        //        var exporter = new OxyPlot.WindowsForms.PngExporter { Width = 800, Height = 600, Background = OxyColors.White };
        //        exporter.Export(plotModel, stream);
        //        var imagePath = Path.Combine(System.Web.Hosting.HostingEnvironment.MapPath("~/Content"), "EmployeePieChart.png");
        //        File.WriteAllBytes(imagePath, stream.ToArray());
        //        return imagePath;
        //    }
        //}
    }
}
