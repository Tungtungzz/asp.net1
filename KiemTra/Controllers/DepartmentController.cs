// Controllers/DepartmentController.cs
using Microsoft.AspNetCore.Mvc;
using KiemTra.Models; // Thay đổi theo namespace của bạn
using KiemTra.Entities; // Thay đổi theo namespace của bạn

public class DepartmentController : Controller
{
    private readonly DataContext _context;

    public DepartmentController(DataContext context)
    {
        _context = context;
    }

    // Action để hiển thị danh sách phòng ban
    public IActionResult Index()
    {
        var departments = _context.Departments.ToList(); // Lấy danh sách phòng ban từ cơ sở dữ liệu
        return View(departments);
    }

    // Action để thêm phòng ban
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Department department)
    {
        if (ModelState.IsValid)
        {
            _context.Departments.Add(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(department);
    }

    // Action để chỉnh sửa phòng ban
    public IActionResult Edit(int id)
    {
        var department = _context.Departments.Find(id);
        if (department == null)
        {
            return NotFound();
        }
        return View(department);
    }

    [HttpPost]
    public IActionResult Edit(Department department)
    {
        if (ModelState.IsValid)
        {
            _context.Departments.Update(department);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        return View(department);
    }

    // Action để xóa phòng ban
    public IActionResult Delete(int id)
    {
        var department = _context.Departments.Find(id);
        if (department == null)
        {
            return NotFound();
        }
        return View(department);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var department = _context.Departments.Find(id);
        if (department != null)
        {
            _context.Departments.Remove(department);
            _context.SaveChanges();
        }
        return RedirectToAction("Index");
    }
}
