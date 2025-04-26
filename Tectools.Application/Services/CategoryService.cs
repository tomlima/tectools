using Tectools.Domain.Entities;
using Tectools.Infrastructure.Interfaces;
using Tectools.Application.Interfaces;

namespace Tectools.Application.Services;

public class CategoryService(ICategoryRepository categoryRepository) : ICategoryService
{
    public async Task<List<Category>> GetCategories()
    {
        var categories = await categoryRepository.GetCategories();
        return categories;
    }
}