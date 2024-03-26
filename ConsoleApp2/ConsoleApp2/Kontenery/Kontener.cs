using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;


public class Kontener : IContainer
{
    public double MasaLadunku { get; set; }
    public double MasaWlasna { get; set; }
    public double MaxMasaLadunku { get; set; }
    public double Wysokosc { get; set; }
    public double Glebokosc { get; set; }
    public String NumerSeryjny { get; private set; }
    public String Typ { get; set; }           
    
    private static HashSet<int> generatedNumbers = new HashSet<int>();  

    private static Random random = new Random();                        


    public Kontener(String type, double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku)
    {
        Typ = type;
        NumerSeryjny = GenerateSerialNumber();
        MasaWlasna = masaWlasna;
        MaxMasaLadunku = maxMasaLadunku;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
    }

    public virtual double getMasaCalkowitaKontenera()
    {
        return MasaLadunku + MasaWlasna;
    }
    
    public virtual void Unload()
    {
     Console.WriteLine($"Kontener {NumerSeryjny} -> wyładowano cały ładunek: "+MasaLadunku+" kg");
     MasaLadunku = 0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (MasaLadunku + cargoWeight > MaxMasaLadunku)
        {
            throw new OverfillException("Chcesz zaladować więcej niż kontener może przyjąć");
        }
        else
        {
            MasaLadunku += cargoWeight;
            Console.WriteLine($"Kontener {NumerSeryjny} -> Zaladowano: "+cargoWeight+" kg, lączna masa ladunku: " + MasaLadunku +" kg");
        }
    }

    public virtual void Unload(double weight)
    {
        if (weight > MasaLadunku)
        {
            throw new NotEnoughCargoException("Chcesz wyladować więcej ladunku niż znajduje się w kontenerze");
        }
        else
        {
            MasaLadunku -= weight;
            Console.WriteLine("Wyladowano: "+weight+" kg, pozostalo " + MasaLadunku +" kg");
        }
    }
    
    private string GenerateSerialNumber()                                                          
    {                                                                                              
        int number;                                                                                
        do                                                                                         
        {                                                                                          
            number = random.Next(1, 1000); // zakładamy zakres unikalnych liczb od 1 do 999        
        } while (generatedNumbers.Contains(number));                                               
                                                                                               
        generatedNumbers.Add(number);                                                              
        return $"KON-{Typ}-{number}";                                                             
    }                                                                                              
}