namespace eShop.Models
{
    public class ProductType
    {
        public int ClothesId { get; set; }
        public Clothes Clothes { get; set; }
        public int ProductId {  get; set; }
        public Product Product { get; set; }
    }
}
