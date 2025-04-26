namespace Tectools.Domain.Entities;

public class Compability
{
    required 
    public int Id { get; set; }
    
    required
    public Category ComponentCategoryA { get; set; }
    
    required 
    public Category ComponentCategoryB { get; set; }
    
    required
    public string RuleType { get; set; }
}