using eShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShop.Controllers
{
    public class AccesoriesController : Controller
    {
        private readonly AppDbContext _context;

        public AccesoriesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task <IActionResult> Index()
        {
            var allAccesories = await _context.Accesories.ToListAsync();
            return View(allAccesories);
        }
    }
}
