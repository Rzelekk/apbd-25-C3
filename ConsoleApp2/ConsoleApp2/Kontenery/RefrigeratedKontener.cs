using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class RefrigeratedKontener : Kontener, IContainer
{
    public RefrigeratedKontener(string type, double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base(type, masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
    {
    }

    public override void Unload()
    {
        base.Unload();
    }

    public override void Load(double cargoWeight)
    {
        base.Load(cargoWeight);
    }

    public override void Unload(double weight)
    {
        base.Unload(weight);
    }
}