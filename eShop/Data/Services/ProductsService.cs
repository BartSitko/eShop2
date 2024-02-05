﻿using eShop.Models;
using Microsoft.EntityFrameworkCore;

namespace eShop.Data.Services
{
    public class ProductsService : IProductsService
    {
        private readonly AppDbContext _context;
        public ProductsService(AppDbContext context)
        {
             _context = context;
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
           await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            var result = await _context.Products.ToListAsync();
            return result;
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            var result = await _context.Products.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public async Task <Product> UpdateAsync(int id, Product newProduct)
        {
            _context.Update(newProduct);
            await _context.SaveChangesAsync();
            return newProduct;
        }
    }
}
