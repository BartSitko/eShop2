using System.ComponentModel.DataAnnotations;

namespace eShop.Models
{
    public class Accesories
    {
        [Key]
        public int Id { get; set; }
        public string PictureURL { get; set; }
        public string Name {  get; set; }
        public string Description { get; set; }
        //Relacja
        public List<Clothes> Clothes {  get; set; }    
    }
}
