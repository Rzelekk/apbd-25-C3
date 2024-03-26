using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class GasKontener : Kontener, IContainer, IHazardNotifier
{

    public double Cisnienie { get; set; }
    public GasKontener(double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base("G", masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
    {
    }

    public override void Unload()
    {
        Console.WriteLine("Wyladowano caly ladunek: "+MasaLadunku*0.95+" kg");
        MasaLadunku -= MasaLadunku*0.95;
    }

    public override void Unload(double weight)
    {
        base.Unload(weight*0.95);
    }
}