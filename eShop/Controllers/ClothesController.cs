using eShop.Data;
using eShop.Data.Services;
using eShop.Data.Static;
using eShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace eShop.Controllers
{
    [Authorize(Roles = UserRoles.Admin)]
    public class ClothesController : Controller
    {
        private readonly IClothesService _service;

        public ClothesController(IClothesService service)
        {
            _service = service;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var allClothes = await _service.GetAllAsync();
            return View(allClothes);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Filter(string searchString)
        {
            var allClothes = await _service.GetAllAsync();

            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allClothes.Where(n => n.Name.Contains(searchString) || n.Description.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }


            return View("Index", allClothes);
        }

        //GET
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            var clothesDetail = await _service.GetClothesByIdAsync(id);
            return View(clothesDetail);
        }

        
        public async Task<IActionResult> Create()
        {
            var clothesDropdownsData = await _service.GetNewClothesDropdownsValues();

            ViewBag.Marks = new SelectList(clothesDropdownsData.Marks, "Id", "Name");
            ViewBag.Accesories = new SelectList(clothesDropdownsData.Accesories, "Id", "Name");
            ViewBag.Products = new SelectList(clothesDropdownsData.Products, "Id", "Name");

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NewClothesVM clothes)
        {
            if (!ModelState.IsValid)
            {
                var clothesDropdownsData = await _service.GetNewClothesDropdownsValues();

                ViewBag.Marks = new SelectList(clothesDropdownsData.Marks, "Id", "Name");
                ViewBag.Accesories = new SelectList(clothesDropdownsData.Accesories, "Id", "Name");
                ViewBag.Products = new SelectList(clothesDropdownsData.Products, "Id", "Name");

                return View(clothes);
            }

            await _service.AddNewClothesAsync(clothes);
            return RedirectToAction(nameof(Index));
        }

        //EDYCJA
        public async Task<IActionResult> Edit(int id)
        {
            var clothesDetails = await _service.GetClothesByIdAsync(id);
            if (clothesDetails == null) return View("NotFound");

            var respone = new NewClothesVM()
            {
                Id = clothesDetails.Id,
                Name = clothesDetails.Name,
                Description = clothesDetails.Description,
                Price = clothesDetails.Price,
                StartDate = clothesDetails.StartDate,
                EndDate = clothesDetails.EndDate,
                ImageURL = clothesDetails.ImageURL,
                ProductCategory = clothesDetails.ProductCategory,
                MarkId = clothesDetails.MarkId,
                AccesoriesId = clothesDetails.AccesoriesId,
                ProductIds = clothesDetails.Product_Types.Select(n => n.ProductId).ToList(),
            };


            var clothesDropdownsData = await _service.GetNewClothesDropdownsValues();

            ViewBag.Marks = new SelectList(clothesDropdownsData.Marks, "Id", "Name");
            ViewBag.Accesories = new SelectList(clothesDropdownsData.Accesories, "Id", "Name");
            ViewBag.Products = new SelectList(clothesDropdownsData.Products, "Id", "Name");

            return View(respone);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewClothesVM clothes)
        {
            if (id != clothes.Id) return View("NotFound");

            if (!ModelState.IsValid)
            {
                var clothesDropdownsData = await _service.GetNewClothesDropdownsValues();

                ViewBag.Marks = new SelectList(clothesDropdownsData.Marks, "Id", "Name");
                ViewBag.Accesories = new SelectList(clothesDropdownsData.Accesories, "Id", "Name");
                ViewBag.Products = new SelectList(clothesDropdownsData.Products, "Id", "Name");

                return View(clothes);
            }

            await _service.UpdateClothesAsync(clothes);
            return RedirectToAction(nameof(Index));

        }
    }
}
