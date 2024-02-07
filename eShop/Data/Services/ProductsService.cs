using eShop.Data.Base;
using eShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eShop.Data.Services
{
    public class ProductsService : EntityBaseRepository<Product>, IProductsService
    {
        
        public ProductsService(AppDbContext context) : base(context) { }
        

    }
}
