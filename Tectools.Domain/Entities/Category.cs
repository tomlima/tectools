using System.ComponentModel.DataAnnotations;
namespace Tectools.Domain.Entities;

public class Category
{
    [Key]
    public int Id { get; set; }
    
    required 
    public string Name { get; set; }
    
    required 
    public string Slug { get; set; }
    
    required 
    public string Icon { get; set; }
}   