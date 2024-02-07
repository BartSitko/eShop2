using eShop.Data.Base;
using eShop.Data.ViewModels;
using eShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eShop.Data.Services
{
    public class ClothesService: EntityBaseRepository<Clothes>, IClothesService
    {
        private readonly AppDbContext _context;
        public ClothesService(AppDbContext context): base(context)
        {
            _context = context;
        }

        public async Task AddNewClothesAsync(NewClothesVM data)
        {
            var newClothes = new Clothes()
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price,
                ImageURL = data.ImageURL,
                MarkId = data.MarkId,
                StartDate = data.StartDate,
                EndDate = data.EndDate,
                ProductCategory = data.ProductCategory,
                AccesoriesId = data.AccesoriesId,
            };
            await _context.Clothes.AddAsync(newClothes);
            await _context.SaveChangesAsync();


            //MBP
            foreach (var ProductId in data.ProductIds)
            {
                var newProductClothes = new ProductType()
                {
                    ClothesId = newClothes.Id,
                    ProductId = ProductId
                };
                await _context.ProductTypes.AddAsync(newProductClothes);

            }
            await _context.SaveChangesAsync();
        }

        public async Task<Clothes> GetClothesByIdAsync(int id)
        {
            var clothesDetails = await _context.Clothes
                .Include(c => c.Mark)
                .Include(p => p.Accesories)
                .Include(am => am.Product_Types).ThenInclude(a => a.Product)
                .FirstOrDefaultAsync(n => n.Id == id);

            return clothesDetails;
        }

        

        public async Task<NewClothesDropdownsVM> GetNewClothesDropdownsValues()
        {
            var response = new NewClothesDropdownsVM();
            response.Products = await _context.Products.OrderBy(n => n.Name).ToListAsync();
            response.Marks = await _context.Marks.OrderBy(n => n.Name).ToListAsync();
            response.Accesories = await _context.Accesories.OrderBy(n => n.Name).ToListAsync();

            return response;
        }

        public async Task UpdateClothesAsync(NewClothesVM data)
        {
            var dbClothes = await _context.Clothes.FirstOrDefaultAsync(n => n.Id == data.Id);

            if (dbClothes != null)
            {

                dbClothes.Name = data.Name;
                dbClothes.Description = data.Description;
                dbClothes.Price = data.Price;
                dbClothes.ImageURL = data.ImageURL;
                dbClothes.MarkId = data.MarkId;
                dbClothes.StartDate = data.StartDate;
                dbClothes.EndDate = data.EndDate;
                dbClothes.ProductCategory = data.ProductCategory;
                dbClothes.AccesoriesId = data.AccesoriesId;
                
                await _context.SaveChangesAsync();
            }

            var existingProductsDb = _context.ProductTypes.Where(n => n.ClothesId == data.Id).ToList();
            _context.ProductTypes.RemoveRange(existingProductsDb);
            await _context.SaveChangesAsync();

            //MBP
            foreach (var ProductId in data.ProductIds)
            {
                var newProductClothes = new ProductType()
                {
                    ClothesId = data.Id,
                    ProductId = ProductId
                };
                await _context.ProductTypes.AddAsync(newProductClothes);

            }
            await _context.SaveChangesAsync();
        }
    }
}
