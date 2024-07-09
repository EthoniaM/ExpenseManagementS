using ExpenseManagementS.DataLayer;
using Microsoft.AspNetCore.Mvc;

namespace ExpenseManagementS.Controllers
{
    public class ExpenseController : Controller
    {
        public readonly DbContextExpMan _context;

        public ExpenseController(DbContextExpMan context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
