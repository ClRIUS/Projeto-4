using BurguerMania.Data;
using BurguerMania.DTOs;
using BurguerMania.Models;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania.Services
{
    public class ProductService
    {
        private readonly MyDbContext _context;

        public ProductService(MyDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductDto>> GetProductsAsync()
        {
            var products = await _context.Products.ToListAsync();
            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Title = p.Title,
                Text = p.Text,
                DetailedDescription = p.DetailedDescription,
                Image = p.Image,
                Price = p.Price,
                CategoryId = p.CategoryId
            }).ToList();
        }

        public async Task<List<ProductDto>> GetProductsByCategoryAsync(int categoryId)
        {
            var products = await _context.Products
                                          .Where(p => p.CategoryId == categoryId)
                                          .ToListAsync();

            return products.Select(p => new ProductDto
            {
                Id = p.Id,
                Title = p.Title,
                Text = p.Text,
                DetailedDescription = p.DetailedDescription,
                Image = p.Image,
                Price = p.Price,
                CategoryId = p.CategoryId
            }).ToList();
        }
    }
}
