using System.ComponentModel.DataAnnotations;

namespace Tectools.Domain.Entities;

public class Brand
{
    [Key]
    public  int Id { get; set; }
    
    required
    public  string Name { get; set; }
    
    required
    public string Logo { get; set; }
    
    public string Website { get; set; }
}