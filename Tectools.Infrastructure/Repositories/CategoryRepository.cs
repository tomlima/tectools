using Tectools.Domain.Entities;
using Tectools.Infrastructure.Interfaces;

namespace Tectools.Infrastructure.Repositories;

public class CategoryRepository(ApplicationDbContext context):ICategoryRepository
{
    
    public async Task<List<Category>> GetCategories()
    {
        List<Category> categories = context.Categories.ToList();
        return categories;
    }
}