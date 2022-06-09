using Microsoft.AspNetCore.Mvc;
using VacationManagement.Data;

namespace VacationManagement.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly VacationDbContext _context;

        public DepartmentsController(VacationDbContext _context)
        {
            _context = context;
        }
        public IActionResult Departments()
        {
            return View(_context.Departments.OrderBy(x=>x.Name).ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
