using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class EmployeeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            var employees = await EmployeeService.GetEmployeeData();

            // Sort employees by TotalTimeWorked in descending order
            var sortedEmployees = employees.OrderByDescending(e => e.TotalTimeWorked).ToList();

            return View(sortedEmployees);
        }
        //public async Task<ActionResult> GenerateChart()
        //{
        //    var employees = await EmployeeService.GetEmployeeData();

        //    // Define file path for the generated image
        //    string filePath = Server.MapPath("~/Content/EmployeeTimeChart.png");

        //    // Generate the pie chart
        //    ChartService.GeneratePieChart(employees, filePath);

        //    // Return the image file to the browser
        //    return File(filePath, "image/png");
        //}
    }
}
