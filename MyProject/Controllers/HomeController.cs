using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MyProject.Models;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult GetMatrix(TaskModel model)
        {
            // Convert input format like "[1,2,3]" to string[] array {"1", "2", "3"}
            string[] inputData = model.Matrix
                .Replace(" ", string.Empty)
                .Replace("[", string.Empty)
                .Replace("]", string.Empty)
                .Split(",");

            try
            {
                // Try to convert 'inputData' into int[] array
                int[] inputNumbers = inputData
                    .Select(item => Convert.ToInt32(item))
                    .OrderByDescending(item => item)
                    .ToArray();

                // Create groups with elements that repeat at least 3 times
                var groups = inputNumbers
                    .GroupBy(item => item)
                    .Where(item => item.Count() >= 3);

                // Create an output with selected values
                model.Matrix = "[" + string.Join(",", groups.Select(item => item.Key)) + "]";
            }
            catch
            {
                // Send an error message if conversion is impossible
                model.Matrix = "Error";
            }

            return View("Index", model);
        }
    }
}
