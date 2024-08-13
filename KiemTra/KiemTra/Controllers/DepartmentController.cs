using Microsoft.AspNetCore.Mvc;
using KiemTra.Models;
using KiemTra.Entities;
using System.Linq;
using System.Threading.Tasks;

namespace KiemTra.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly DataContext _context;

        public DepartmentController(DataContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var departments = _context.Departments.ToList();
            return View(departments);
        }

        // Create, Edit, Delete actions here
    }
}
