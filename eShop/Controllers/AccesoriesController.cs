using eShop.Data;
using eShop.Data.Static;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShop.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class AccesoriesController : Controller
    {
        private readonly AppDbContext _context;

        public AccesoriesController(AppDbContext context)
        {
            _context = context;
        }

        [AllowAnonymous]
        public async Task <IActionResult> Index()
        {
            var allAccesories = await _context.Accesories.ToListAsync();
            return View(allAccesories);
        }
    }
}
