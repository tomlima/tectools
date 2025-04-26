namespace Tectools.Domain.Entities;

public class Motherboard : Component
{
    public string Socket { get; set; }
    public string Chipset { get; set; }
    public string FormFactor { get; set; } // ATX, mATX, ITX
    public string MemorySupport { get; set; } // DDR4, DDR5
    public int MaxMemory { get; set; }
}