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
    public string Typ { get; private set; }           
    
    private static HashSet<int> generatedNumbers = new HashSet<int>();  

    private static Random random = new Random();                        


    public Kontener(String type, double masaWlasna, double wysokosc, double glebokosc, double maxMasaLadunku)
    {
        NumerSeryjny = GenerateSerialNumber();
        Typ = type;
        MasaWlasna = masaWlasna;
        MaxMasaLadunku = maxMasaLadunku;
        Wysokosc = wysokosc;
        Glebokosc = glebokosc;
    }
    
    
    
    public virtual void Unload()
    {
        throw new NotImplementedException();
    }

    public void Load(double cargoWeight)
    {
        throw new OverfillException();
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