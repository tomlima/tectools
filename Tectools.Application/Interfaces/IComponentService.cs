using Tectools.Domain.Entities;

namespace Tectools.Application.Interfaces;

public interface IComponentService
{
    Task<List<Component>> GetComponents();
    Task<List<Component>> GetFeaturedComponents();
}