namespace Tectools.Domain.Entities;

public class Peripheral : Component
{
    public string Type { get; set; } // Mouse, Teclado, Headset
    public string Connection { get; set; } // USB, Wireless, Bluetooth
}