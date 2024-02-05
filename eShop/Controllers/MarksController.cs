using eShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShop.Controllers
{
    public class MarksController : Controller
    {
        private readonly AppDbContext _context;

        public MarksController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allMarks = await _context.Marks.ToListAsync();
            return View(allMarks);
        }
    }
}
