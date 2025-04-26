namespace Tectools.Domain.Entities;

public class Gpu : Component
{
    public string Chipset { get; set; }
    public string Memory { get; set; }
    public string MemoryType { get; set; }
    public string Interface { get; set; }
    public string Tdp { get; set; }
}