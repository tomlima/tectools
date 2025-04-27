using System.ComponentModel.DataAnnotations;

namespace Tectools.Domain.Entities;

public class Link
{
    [Key]
    public int Id { get; set; }
    public Component Component { get; set; }
    public string Url { get; set; }
}