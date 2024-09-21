using CodePulse.API.Data;
using CodePulse.API.Models.Domain;
using CodePulse.API.Repositories.Interface;
using Microsoft.EntityFrameworkCore;

namespace CodePulse.API.Repositories.Implementation
{
    public class CategoryRepositary : ICategoryRepositary
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepositary(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Category> createAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return category;
        }
    }
}
