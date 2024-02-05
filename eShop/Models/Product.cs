using System.ComponentModel.DataAnnotations;

namespace eShop.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        
        [Display(Name = "PictureURL")]
        [Required(ErrorMessage ="Picture is required")]
        public string PictureURL {  get; set; }
        
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Name between 3 a 50")]
        public string Description { get; set; }

        //Relacja
        public List<ProductType> Product_Types { get; set; }
    }
}
