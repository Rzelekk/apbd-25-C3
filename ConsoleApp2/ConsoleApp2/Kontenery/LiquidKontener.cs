using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class LiquidKontener : Kontener, IHazardNotifier, IContainer
{
    public Boolean HazardCargo;
    
    public LiquidKontener(double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku) : base("L", masaWlasna, wysokosc, glebokosc, maxMasaLadunku)
    {
        
    }


    public override void Unload(double weight)
    {
        base.Unload(weight);
    }

    public override void Load(double cargoWeight)
    {
        if (HazardCargo)
        {
            if (MasaLadunku + cargoWeight > MaxMasaLadunku / 2)
            {
                HazardNotification(NumerSeryjny,"Próba zaladowania ladunku niebezpiecznego w masie wiekszej niz dopuszczalne normy");
               // throw new OverfillException("Masa ladunku przekracza dopuszczalny poziom dla ladunku niebezpiecznego!!");
            }
            else
            {
                MasaLadunku += cargoWeight;
            }
        }
        else
        {
            if (MasaLadunku + cargoWeight > MaxMasaLadunku*0.9)
            {
                HazardNotification(NumerSeryjny,"Proba zaladowania kontenera ponad 90% dopuszczalnej ladownosci");
                //throw new OverfillException("Chcesz zaladować więcej niż kontener może przyjąć");
            }
            else
            {
                MasaWlasna += cargoWeight;
                Console.WriteLine("Zaladowano: "+cargoWeight+" kg, lączna masa ladunku: " + MasaLadunku +" kg");
            }
        }
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