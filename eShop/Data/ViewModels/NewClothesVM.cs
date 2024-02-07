using eShop.Data.Base;
using eShop.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Models
{
    public class NewClothesVM
    {
        public int Id {  get; set; }

        [Required(ErrorMessage ="Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }
       
        [Required(ErrorMessage = "Desc is required")]
        [Display(Name = "Description")]
        public string Description {  get; set; }

        [Required(ErrorMessage = "Price is required")]
        [Display(Name = "Price")]
        public double Price {  get; set; }

        [Required(ErrorMessage = "ImageURL is required")]
        [Display(Name = "ImageURL")]
        public string ImageURL {  get; set; }

        [Required(ErrorMessage = "StartDate is required")]
        [Display(Name = "StartDate")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "EndDate is required")]
        [Display(Name = "EndDate")]
        public DateTime EndDate { get; set; }

        [Required(ErrorMessage = "ProductCat is required")]
        [Display(Name = "ProductCategory")]
        public ProductCategory ProductCategory { get; set; }

        //Relacja
        [Required(ErrorMessage = "Product is required")]
        [Display(Name = "Select Product")]
        public List<int> ProductIds { get; set; }

        [Required(ErrorMessage = "Mark is required")]
        [Display(Name = "Select Mark")]
        public int MarkId {  get; set; }


        [Required(ErrorMessage = "Accesory is required")]
        [Display(Name = "Select Accesories")]
        public int AccesoriesId { get; set; }
        





    }
}
