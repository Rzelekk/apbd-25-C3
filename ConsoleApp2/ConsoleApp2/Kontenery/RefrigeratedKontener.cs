using ConsoleApp2.Enums;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class RefrigeratedKontener : Kontener, IContainer
{
    public Products RodzajProduktu { get; set; } = Products.BrakTowaru;
    public double Temperatura { get; set; }
    public RefrigeratedKontener(string type, double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base(type, masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
    {
    }

    private double setupTemperature(Products product)
    {
        double temp = 0.0;

        switch (product)
        {
            case Products.Banana:
                temp = 13.3;
                break;
            case Products.Chocolate:
                temp = 18;
                break;
            case Products.Fish:
                temp = 2;
                break;
            case Products.Meat:
                temp = -15;
                break;
            case Products.IceCream:
                temp = -18;
                break;
            case Products.FrozenPizza:
                temp = -30;
                break;
            case Products.Cheese:
                temp = 7.2;
                break;
            case Products.Sausages:
                temp = 5;
                break;
            case Products.Butter:
                temp = 20.5;
                break;
            case Products.Eggs:
                temp = 19;
                break;
        }

        return temp;
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