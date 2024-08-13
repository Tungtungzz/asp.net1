using Microsoft.AspNetCore.Mvc;
using KiemTra.Models;
using KiemTra.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace KiemTra.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly DataContext _context;

        public EmployeeController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Create()
        {
            ViewBag.Departments = _context.Departments.ToList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Department");
            }
            return View(employee);
        }

        // Other actions here
    }
}
