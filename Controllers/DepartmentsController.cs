using Microsoft.AspNetCore.Mvc;

namespace WorldDominion
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Dictionary<string, object>> data = new()
            {
                new() { { "Id", "1" }, { "Name", "Fruits & Veg" } },
                new() { { "Id", "2" }, { "Name", "Meats" } },
                new() { { "Id", "3" }, { "Name", "Sweets & Treats" } },
            };

            return View(data);
        }
    }
}