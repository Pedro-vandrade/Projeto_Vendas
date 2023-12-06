using Microsoft.AspNetCore.Mvc;
using SalesProject.Models;

namespace SalesProject.Controllers
{
    public class DepartmenstController : Controller
    {
        public IActionResult Index()
        {

            List<Department> list = new List<Department>();
            list.Add(new Department { Id = 1, Name = "Elétronicos" });
            list.Add(new Department { Id = 2, Name = "Cozinha" });
            list.Add(new Department { Id = 3, Name = "Informática" });



            return View(list);
        }
    }
}
