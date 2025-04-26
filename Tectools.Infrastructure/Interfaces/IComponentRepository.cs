using Tectools.Domain.Entities;

namespace Tectools.Infrastructure.Interfaces;

public interface IComponentRepository
{
    Task<List<Component>> GetComponents();
    Task<List<Component>> GetFeaturedComponents();
}