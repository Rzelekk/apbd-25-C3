﻿using ConsoleApp2.Enums;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class RefrigeratedKontener : Kontener, IContainer
{
    public Products RodzajProduktu { get; set; } = Products.BrakTowaru;
    public double Temperatura { get; set; }
    public RefrigeratedKontener(double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base("C", masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
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
        Console.WriteLine("Musisz podać typ produktu który chcesz załadować do chłodni");
    }
    
    public void Load(double cargoWeight, Products product)
    {
        if (RodzajProduktu == Products.BrakTowaru || RodzajProduktu == product)
        {
            if (RodzajProduktu == product)
            {
                base.Load(cargoWeight);
            }
            else
            {
                RodzajProduktu = product;
                Temperatura = setupTemperature(product);
                base.Load(cargoWeight);
            }
        }
        else
        {
            Console.WriteLine($"Nie można załadować {product} poniważ w kontenerze znajduje się już {RodzajProduktu}");
        }
    }

    public override void Unload(double weight)
    {
        base.Unload(weight);
    }
    
    public override string ShowKontener()
    {
        return $"Kontener {NumerSeryjny}: \n" +
               $"   -Masa własna -> {MasaWlasna} kg\n" +
               $"   -Masa ładunku -> {MasaLadunku} kg\n" +
               $"   -Masa całkowita -> {getMasaCalkowitaKontenera()} kg\n" +
               $"   -Masa wysokość -> {Wysokosc} cm\n" +
               $"   -Masa głębokość -> {Glebokosc} cm\n" +
               $"   -typ kontenera -> {Typ}\n" +
               $"   -Rodzaj ładunku -> {RodzajProduktu}\n" +
               $"   -Temperatura -> {Temperatura}\u00b0C";
    }
}