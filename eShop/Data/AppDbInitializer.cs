using eShop.Data.Enums;
using eShop.Models;
using static System.Net.WebRequestMethods;

namespace eShop.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Mark
                if(!context.Marks.Any())
                {
                    context.Marks.AddRange(new List<Mark>()
                    {
                        new Mark()
                        {
                            Name = "AAA",
                            Logo = "https://cdn.pixabay.com/photo/2013/07/12/12/36/letter-145995_1280.png",
                            Description = "This is the AAA Mark"
                        },
                        new Mark()
                        {
                            Name = "BBB",
                            Logo = "https://cdn.pixabay.com/photo/2013/07/12/12/36/letter-145996_1280.png",
                            Description = "This is the BBB Mark"
                        }
                    });
                    context.SaveChanges();
                    
                }
                //Accesories
                if (!context.Accesories.Any())
                {
                    context.Accesories.AddRange(new List<Accesories>()
                    {
                        new Accesories()
                        {
                            Name = "Belt",
                            PictureURL = "https://cdn.pixabay.com/photo/2013/07/12/17/57/belt-152698_1280.png",
                            Description = "accesory belt"
                        }
                    });
                    context.SaveChanges();

                }

                //Clothes
                if (!context.Clothes.Any())
                {
                    context.Clothes.AddRange(new List<Clothes>()
                    {
                        new Clothes()
                        {
                            Name = "Tshirt",
                            Description = "Nice Tshirt",
                            Price = 10,
                            ImageURL = "https://cdn.pixabay.com/photo/2012/04/14/16/20/t-shirt-34481_1280.png",
                            StartDate = DateTime.Now.AddDays(-10),
                            EndDate = DateTime.Now.AddDays(10),
                            MarkId = 1,
                            AccesoriesId = 1,
                            ProductCategory = ProductCategory.L
                        },
                         new Clothes()
                        {
                            Name = "Hoodie",
                            Description = "Nice Hoodie",
                            Price = 20,
                            ImageURL = "https://cdn.pixabay.com/photo/2023/05/30/16/49/hoodie-8029137_1280.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(3),
                            MarkId = 2,
                            AccesoriesId = 1,
                            ProductCategory = ProductCategory.XL
                        },
                          new Clothes()
                        {
                            Name = "Shoes",
                            Description = "Nice Shoes",
                            Price = 15,
                            ImageURL = "https://cdn.pixabay.com/photo/2014/04/02/10/43/sneakers-304334_1280.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(5),
                            MarkId = 1,
                            AccesoriesId = 1,
                            ProductCategory = ProductCategory.S
                        },
                           new Clothes()
                        {
                            Name = "Pants",
                            Description = "Nice Pants",
                            Price = 30,
                            ImageURL = "https://cdn.pixabay.com/photo/2013/07/13/11/32/pants-158358_1280.png",
                            StartDate = DateTime.Now,
                            EndDate = DateTime.Now.AddDays(10),
                            MarkId = 2,
                            AccesoriesId = 1,
                            ProductCategory = ProductCategory.M
                        }
                    });
                    context.SaveChanges();


                }
               
                //Product
                if (!context.Products.Any())
                {
                    context.Products.AddRange(new List<Product>()
                    {
                        new Product()
                        {
                            PictureURL = "https://cdn.pixabay.com/photo/2012/04/14/16/20/t-shirt-34481_1280.png",
                            Name = "Tshirt",
                            Description = "Nice looking shirt"
                        },
                        new Product()
                        {
                            PictureURL = "https://cdn.pixabay.com/photo/2023/05/30/16/49/hoodie-8029137_1280.png",
                            Name = "Hoodie",
                            Description = "Nice looking Hoodie"
                        },
                        new Product()
                        {
                            PictureURL = "https://cdn.pixabay.com/photo/2014/04/02/10/43/sneakers-304334_1280.png",
                            Name = "Shoes",
                            Description = "Nice looking Shoes"
                        },
                        new Product()
                        {
                            PictureURL = "https://cdn.pixabay.com/photo/2013/07/13/11/32/pants-158358_1280.png",
                            Name = "Pants",
                            Description = "Nice looking Pants"
                        },
                    });
                    context.SaveChanges();
                }
                if (!context.ProductTypes.Any())
                {
                    context.ProductTypes.AddRange(new List<ProductType>()
                    {
                        new ProductType()
                        {
                            ProductId = 1,
                            ClothesId = 1,
                        },
                        new ProductType()
                        {
                            ProductId = 2,
                            ClothesId = 2,
                        },
                        new ProductType()
                        {
                            ProductId = 3,
                            ClothesId = 3,
                        },
                        new ProductType()
                        {
                            ProductId = 4,
                            ClothesId = 4,
                        },
                    });
                    

                }




            }
        }
    }
}
