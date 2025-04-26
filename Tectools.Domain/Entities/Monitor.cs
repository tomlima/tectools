namespace Tectools.Domain.Entities;

public class Monitor : Component
{
    public string Resolution { get; set; }
    public string Size { get; set; } // Polegadas
    public int RefreshRate { get; set; }
    public string PanelType { get; set; } // IPS, TN, VA
}
