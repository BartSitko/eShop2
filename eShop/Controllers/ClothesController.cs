using eShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShop.Controllers
{
    public class ClothesController : Controller
    {
        private readonly AppDbContext _context;

        public ClothesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allClothes = await _context.Clothes.ToListAsync();
            return View(allClothes);
        }
    }
}
