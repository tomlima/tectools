using System.Text.Json.Nodes;

namespace Tectools.Domain.Entities;

public class Component
{
    public int Id { get; set; }
    
    required 
    public string Name { get; set; }
    
    required
    public Category Category { get; set; }
    
    required
    public decimal AveragePrice { get; set; }
    
    public string? AffiliateUrl {get; set; }
    
    required
    public Brand? Brand { get; set; }
    
    required 
    public bool Featured { get; set; }
    
    public string Image { get; set; }
    
    public List<UserBuild> UserBuilds { get; set; } = new(); 

}