using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class LiquidKontener : Kontener, IHazardNotifier, IContainer
{
    public Boolean HazardCargo;
    
    public LiquidKontener(double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base("L", masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
    {
        
    }

    public override void Unload()
    {
        base.Unload();
    }
    
    public void HazardNotification(string contenerSerial, string tekst)
    {
        Console.Error.WriteLine("---NIEBEZPIECZEŃSTWO---");
        Console.Error.WriteLine($"Kontener {contenerSerial} -> {tekst}");
    }
    
    
}