using Microsoft.AspNetCore.Mvc;
using KiemTra.Models;
using System.Linq;
using KiemTra.Entities;

namespace KiemTra.Controllers
{
    public class ReportController : Controller
    {
        private readonly DataContext _context;

        public ReportController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var report = _context.Departments.Select(d => new
            {
                DepartmentName = d.DepartmentName,
                EmployeeCount = d.Employees.Count
            }).ToList();

            return View(report);
        }
    }
}
