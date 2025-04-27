using System.ComponentModel.DataAnnotations;

namespace Tectools.Domain.Entities;

public class UserBuild
{
    [Key]
    public int Id { get; set; }
    
    required 
    public string Title { get; set; }
    
    required 
    public decimal TotalPrice { get; set; }
    
    required 
    public DateTime CreatedAt { get; set; }
    
    public  List<Component> Components { get; set; } = new List<Component>();
}