namespace Tectools.Domain.Entities;

public class Cooler : Component
{
    public string Type { get; set; } // Air, Liquid
    public string SocketCompatibility { get; set; }
    public string NoiseLevel { get; set; }
}
