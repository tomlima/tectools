namespace Tectools.Domain.Entities;

public class Storage : Component
{
    public string Type { get; set; } // SSD, HDD, NVMe
    public string Capacity { get; set; }
    public string Interface { get; set; } // SATA, M.2, PCIe
    public string ReadSpeed { get; set; }
    public string WriteSpeed { get; set; }
}