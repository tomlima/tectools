namespace Tectools.Domain.Entities;

public class UserBuild
{
    required 
    public int Id { get; set; }
    
    required 
    public string Title { get; set; }
    
    required 
    public decimal TotalPrice { get; set; }
    
    required 
    public DateTime CreatedAt { get; set; }
    
    public  List<Component> Components { get; set; } = new List<Component>();
}