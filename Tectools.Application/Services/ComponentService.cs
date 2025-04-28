using Newtonsoft.Json.Linq;
using Tectools.Infrastructure.Interfaces;
using Tectools.Application.Interfaces;
using Tectools.Domain.Entities;
using Tectools.Infrastructure.Services;


namespace Tectools.Application.Services;

public class ComponentService(IComponentRepository componentRepository): IComponentService
{
    /// <summary>
    /// Get all components 
    /// </summary>
    public async Task<List<Component>> GetComponents()
    {
        var components = await componentRepository.GetComponents();
        return components;
    }

    /// <summary>
    /// Get all featured components
    /// </summary>
    public async Task<List<Component>> GetFeaturedComponents()
    {
        var components = await componentRepository.GetFeaturedComponents();
        return components;
    }

    /// <summary>
    /// Retrieve components from Wikidata.
    /// </summary>
    /// <param name="query">Query to execute</param>
    public async Task<JObject> RetrieveComponents(string query)
    {   
        string endpoint = "https://query.wikidata.org/sparql";
        var url = $"{endpoint}?query={Uri.EscapeDataString(query)}&format=json";
        var result =  await ApiFetcher.FetchAsync(url);
        return result;
    }
}