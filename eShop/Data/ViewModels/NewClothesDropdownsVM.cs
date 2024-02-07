using eShop.Models;

namespace eShop.Data.ViewModels
{
    public class NewClothesDropdownsVM
    {
        public NewClothesDropdownsVM()
        {
            Accesories = new List<Accesories>();
            Marks = new List<Mark>();
            Products = new List<Product>();

        }
        public List<Accesories> Accesories { get; set; }
        public List<Mark> Marks { get; set; }
        public List<Product> Products { get; set; }
    }
}
