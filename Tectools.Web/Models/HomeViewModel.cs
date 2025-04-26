using Tectools.Domain.Entities;

namespace Tectools.Web.Models;


public class HomeViewModel
{
    public List<Component> Components { get; set; }
    public List<Component> FeaturedComponents { get; set; }
    public List<Category> Categories { get; set; }
}