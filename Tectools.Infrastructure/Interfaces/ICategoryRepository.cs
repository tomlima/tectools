using Tectools.Domain.Entities;

namespace Tectools.Infrastructure.Interfaces;

public interface ICategoryRepository
{
    public Task<List<Category>> GetCategories();
}