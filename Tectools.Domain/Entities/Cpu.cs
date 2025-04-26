namespace Tectools.Domain.Entities;

public class Cpu: Component
{
    public string Socket { get; set; }
    public int Cores { get; set; }
    public int Threads { get; set; }
    public string BaseClock { get; set; }
    public string BoostClock { get; set; }
    public string Tdp { get; set; }
}