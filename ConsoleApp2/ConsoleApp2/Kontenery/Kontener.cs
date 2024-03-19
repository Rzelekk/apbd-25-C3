using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;


public class Kontener : IContainer
{
    public double MasaLadunku { get; set; }
    public double MasaWlasna { get; set; }
    public double Wysokosc { get; set; }
    public double Glebokosc { get; set; }
    


    public Kontener(double masaLadunku, double wysokosc)
    {
        MasaLadunku = masaLadunku;
        Wysokosc = wysokosc;
    }
    
    
    
    public virtual void Unload()
    {
        throw new NotImplementedException();
    }

    public void Load(double cargoWeight)
    {
        throw new OverfillException();
    }
}