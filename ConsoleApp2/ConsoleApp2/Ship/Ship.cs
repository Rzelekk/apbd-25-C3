using ConsoleApp2.Kontenery;

namespace ConsoleApp2.Ship;

public class Ship
{
    public List<Kontener> KontenerList = new List<Kontener>();
    public int MaxKontenerCount { get; private set; }
    public int MaxKontenerLoad { get; set; }
    private int ActualKontenerCount { get; set; } = 0;
    private double ActualKontenerLoad { get; set; }
    private double MaxSpeed { get; set; }
    public String Nazwa { get; set; }

    public Ship(String nazwa,int maxKontenerCount, int maxKontenerLoad, double maxSpeed)
    {
        Nazwa = nazwa;
        MaxKontenerCount = maxKontenerCount;
        MaxKontenerLoad = maxKontenerLoad;
        MaxSpeed = maxSpeed;
    }

    public void ShowLadunek()
    {
        Console.WriteLine($"\n=======Ładunek Statku {Nazwa}=======");
        foreach (var kontener in KontenerList)
        {
            Console.WriteLine(kontener.ShowKontener());
        }
        Console.WriteLine("==================================");
    }
    

    public void LoadContainer(Kontener kontener)
    {
        if (IsPossibleToLoad(kontener))
        {
            KontenerList.Add(kontener);
            ActualKontenerCount++;
        }
        else
        {
            Console.WriteLine("Nie można załadować kontenera!");
        }
    }

    public void LoadContainer(List<Kontener> listaDoZaladunku)
    {
        foreach (var kontener in listaDoZaladunku)
        {
            if (IsPossibleToLoad(kontener))
            {
                KontenerList.Add(kontener);
                ActualKontenerCount++;
            }
            else
            {
                Console.WriteLine("Nie można załadować kontenera!");
            }
        }
    }

    public void UnloadContainer(string SerialNumber)
    {
        int indexDoWyladunku = KontenerList.FindIndex(k => k.NumerSeryjny == SerialNumber);
    
        if(indexDoWyladunku == -1)
        {
            Console.WriteLine($"Nie można znaleźć kontenera o numerze seryjnym {SerialNumber}.");
        }
        
        KontenerList.RemoveAt(indexDoWyladunku);
        Console.WriteLine($"Usunięto kontener o numerze {SerialNumber} ze statku {Nazwa}");
    }
    
    public void UnloadContainer(int ConteinerNumberAtShip)
    {
        if (ConteinerNumberAtShip < KontenerList.Count)
        {
            Console.WriteLine($"Usunięto kontener o numerze {KontenerList[ConteinerNumberAtShip].NumerSeryjny} ze statku {Nazwa}");
            KontenerList.RemoveAt(ConteinerNumberAtShip);
        }
    }

    public void UnloadAllFromShip()
    {
        for (int i = 0; i < KontenerList.Count; i++)
        {
            Console.WriteLine($"Usunięto kontener o numerze {KontenerList[i].NumerSeryjny} ze statku {Nazwa}");
            KontenerList.RemoveAt(i);
        }
    }

    private Boolean IsPossibleToLoad(Kontener kontener)
    {
        if (KontenerList.Count < MaxKontenerCount)
        {
            return true;
        }
        else if (ActualKontenerLoad + (kontener.getMasaCalkowitaKontenera()/1000) < MaxKontenerLoad)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SwapKonteners(Kontener kontenerDoZaladunku, string numerSeryjnyDoWyladunku)
    {
        int indexDoWyladunku = KontenerList.FindIndex(k => k.NumerSeryjny == numerSeryjnyDoWyladunku);
    
        if(indexDoWyladunku == -1)
        {
            Console.WriteLine($"Nie można znaleźć kontenera o numerze seryjnym {numerSeryjnyDoWyladunku}.");
            return;
        }
        
        int indexDoZaladunku = KontenerList.FindIndex(k => k.NumerSeryjny == kontenerDoZaladunku.NumerSeryjny);
    
        if(indexDoZaladunku == -1)
        {
            Console.WriteLine($"Nie można znaleźć kontenera o numerze seryjnym {kontenerDoZaladunku.NumerSeryjny}.");
            return;
        }

        //Kontener temp = KontenerList[indexDoWyladunku];
        KontenerList[indexDoWyladunku] = kontenerDoZaladunku;
        // KontenerList[indexDoZaladunku] = temp;

        Console.WriteLine($"Zamieniono kontener o numerze seryjnym {kontenerDoZaladunku.NumerSeryjny} z kontenerem o numerze seryjnym {numerSeryjnyDoWyladunku}.");
    }


    public void showShip()
    {
        Console.WriteLine("==============Statek info=============\n" +
               $"   -Nazwa: {Nazwa}\n" +
               $"   -Prędkość: {MaxSpeed} kt\n" +
               $"   -Maksymalna liczba kontenerów: {MaxKontenerCount}\n" +
               $"   -Maksymalna waga kontenerów: {MaxKontenerLoad} T\n" +
               $"   -Aktualna liczba kontenerów: {ActualKontenerCount}\n"+
               $"   -Aktualna masa kontenerów: {ActualKontenerLoad} T\n"+
        
                "======================================");
    }
}