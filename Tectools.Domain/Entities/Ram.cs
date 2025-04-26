namespace Tectools.Domain.Entities;

public class Ram : Component
{
    public string Type { get; set; } // DDR4, DDR5
    public string Speed { get; set; }
    public string Capacity { get; set; }
    public int Modules { get; set; } // Quantidade de pentes
}