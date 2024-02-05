﻿using eShop.Models;

namespace eShop.Data.Services
{
    public interface IProductsService
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task <Product> GetByIdAsync(int id);
        Task AddAsync(Product product);
        Task<Product> UpdateAsync(int id, Product newProduct);
        void Delete(int id);
    }
}
