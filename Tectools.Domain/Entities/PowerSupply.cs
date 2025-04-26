namespace Tectools.Domain.Entities;

public class PowerSupply : Component
{
    public int Wattage { get; set; }
    public string Certification { get; set; } // 80 Plus Bronze, Gold, etc.
    public bool Modular { get; set; }
}
