using System.ComponentModel.DataAnnotations;

namespace Tectools.Domain.Entities;

public class Compability
{
    [Key]
    public int Id { get; set; }
    
    required
    public Category ComponentCategoryA { get; set; }
    
    required 
    public Category ComponentCategoryB { get; set; }
    
    required
    public string RuleType { get; set; }
}