﻿using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class LiquidKontener : Kontener, IHazardNotifier, IContainer
{
    public Boolean HazardCargo;
    
    public LiquidKontener(double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base("L", masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
    {
        
    }
    
    public void Load(double cargoWeight, Boolean hazardCargo)
    {
        if (hazardCargo)
        {
            HazardCargo = true;
            if (MasaLadunku + cargoWeight > MaxMasaLadunku / 2)
            {
                
                IHazardNotifier.HazardNotification(NumerSeryjny,"Próba zaladowania ladunku niebezpiecznego w masie wiekszej niz dopuszczalne normy");
               // throw new OverfillException("Masa ladunku przekracza dopuszczalny poziom dla ladunku niebezpiecznego!!");
            }
            else
            {
                MasaLadunku += cargoWeight;
                Console.WriteLine($"Kontener {NumerSeryjny} -> Zaladowano: "+cargoWeight+" kg, lączna masa ladunku: " + MasaLadunku +" kg");
            }
        }
        else
        {
            if (MasaLadunku + cargoWeight > MaxMasaLadunku*0.9)
            {
                IHazardNotifier.HazardNotification(NumerSeryjny,"Proba zaladowania kontenera ponad 90% dopuszczalnej ladownosci");
                //throw new OverfillException("Chcesz zaladować więcej niż kontener może przyjąć");
            }
            else
            {
                MasaWlasna += cargoWeight;
                Console.WriteLine($"Kontener {NumerSeryjny} -> Zaladowano: "+cargoWeight+" kg, lączna masa ladunku: " + MasaLadunku +" kg");
            }
        }
    }
    
    public override string ShowKontener()
    {
        if (HazardCargo)
        {
            return $"Kontener {NumerSeryjny}: \n" +
                   $"   -Masa własna -> {MasaWlasna} kg\n" +
                   $"   -Masa ładunku -> {MasaLadunku} kg\n" +
                   $"   -Masa całkowita -> {getMasaCalkowitaKontenera()} kg\n" +
                   $"   -Masa wysokość -> {Wysokosc} cm\n" +
                   $"   -Masa głębokość -> {Glebokosc} cm\n" +
                   $"   -Typ kontenera-> {Typ}\n" + 
                   $"   -Hazard Cargo -> TAK\n";
        }
        else
        {
            return base.ShowKontener();
        }
    }
    
}