using Tectools.Domain.Entities;
using Tectools.Infrastructure.Data;
using Tectools.Infrastructure.Interfaces;

namespace Tectools.Infrastructure.Repositories;

public class ComponentRepository(ApplicationDbContext context):IComponentRepository
{
    public async Task<List<Component>> GetComponents()
    {
        return context.Components.ToList();
    }

    public async Task<List<Component>> GetFeaturedComponents()
    {
        return context.Components.Where(p => p.Featured == true).ToList();
    }
}