using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class GasKontener : Kontener, IContainer, IHazardNotifier
{

    public double cisnienie;
    public GasKontener(string type, double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base(type, masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
    {
    }

    public override void Unload()
    {
        Console.WriteLine("Wyladowano caly ladunek: "+MasaLadunku*0.95+" kg");
        MasaLadunku -= MasaLadunku*0.95;
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }

    public override void Unload(double weight)
    {
        base.Unload(weight*0.95);
    }
}