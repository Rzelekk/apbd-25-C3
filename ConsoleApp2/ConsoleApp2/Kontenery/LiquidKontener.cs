using ConsoleApp2.Exceptions;
using ConsoleApp2.Interfaces;

namespace ConsoleApp2.Kontenery;

public class LiquidKontener : Kontener, IHazardNotifier, IContainer
{
    public LiquidKontener(double masaLadunku, double wysokosc) : base(masaLadunku, wysokosc)
    {
        
        
        
    }

    public override void Unload()
    {
        base.Unload();
    }
}