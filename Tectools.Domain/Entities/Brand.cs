namespace Tectools.Domain.Entities;

public class Brand
{
    public  int Id { get; set; }
    public required string Name { get; set; }
    
    public required string Logo { get; set; }
    
    public string Website { get; set; }
}