using System.ComponentModel.DataAnnotations;

namespace eShop.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
        [Display(Name="Logo")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        public string Description { get; set; }

        //Relacja
        public List<Clothes> Clothes { get; set; }


    }
}
