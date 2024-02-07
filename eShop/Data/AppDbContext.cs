using eShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace eShop.Data
{
    public class AppDbContext: IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {         
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ProductType>().HasKey(am => new
            {
              am.ProductId,
              am.ClothesId
            });

            modelBuilder.Entity<ProductType>().HasOne(m => m.Clothes).WithMany(am => am.Product_Types).HasForeignKey(m => m.ClothesId);
            modelBuilder.Entity<ProductType>().HasOne(m => m.Product).WithMany(am => am.Product_Types).HasForeignKey(m => m.ProductId);


            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Clothes> Clothes { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<Accesories> Accesories { get; set; }


        //Zamowienia
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set;}
    }
}
