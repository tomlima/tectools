using Tectools.Domain.Entities;

namespace Tectools.Application.Interfaces;

public interface ICategoryService
{
    public Task<List<Category>> GetCategories();
}