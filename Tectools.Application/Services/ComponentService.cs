using Tectools.Infrastructure.Interfaces;
using Tectools.Application.Interfaces;
using Tectools.Domain.Entities;


namespace Tectools.Application.Services;

public class ComponentService(IComponentRepository componentRepository): IComponentService
{
    public async Task<List<Component>> GetComponents()
    {
        var components = await componentRepository.GetComponents();
        return components;
    }

    public async Task<List<Component>> GetFeaturedComponents()
    {
        var components = await componentRepository.GetFeaturedComponents();
        return components;
    }
}