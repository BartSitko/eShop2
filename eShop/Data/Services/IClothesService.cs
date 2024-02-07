using eShop.Data.Base;
using eShop.Data.ViewModels;
using eShop.Models;

namespace eShop.Data.Services
{
    public interface IClothesService: IEntityBaseRepository<Clothes>
    {
        Task<Clothes> GetClothesByIdAsync(int id);
        Task<NewClothesDropdownsVM> GetNewClothesDropdownsValues();
        Task AddNewClothesAsync(NewClothesVM data);
        Task UpdateClothesAsync(NewClothesVM data);

    }
}
