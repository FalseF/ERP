using ERP.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ERP.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            return View();
        }
    }
}
