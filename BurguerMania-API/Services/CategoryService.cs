using BurguerMania.Data;
using BurguerMania.DTOs;
using BurguerMania.Models;
using Microsoft.EntityFrameworkCore;

namespace BurguerMania.Services
{
    public class CategoryService
    {
        private readonly MyDbContext _context;

        public CategoryService(MyDbContext context)
        {
            _context = context;
        }

        // Método para pegar todas as categorias
        public async Task<List<CategoryDto>> GetCategoriesAsync()
        {
            var categories = await _context.Categories.ToListAsync();
            return categories.Select(c => new CategoryDto
            {
                Id = c.Id,
                Title = c.Title,
                Text = c.Text,
                Image = c.Image
            }).ToList();
        }
    }
}
