using eShop.Data.Base;
using eShop.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eShop.Models
{
    public class Clothes: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description {  get; set; }
        public double Price {  get; set; }
        public string ImageURL {  get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public ProductCategory ProductCategory { get; set; }

        //Relacja
        public List<ProductType> Product_Types { get; set; }

        public int MarkId {  get; set; }
        [ForeignKey("MarkId")]
        public Mark Mark { get; set; }

        public int AccesoriesId { get; set; }
        [ForeignKey("AccesoriesId")]
        public Accesories Accesories { get; set; }





    }
}
