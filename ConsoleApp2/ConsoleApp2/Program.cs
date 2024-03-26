
using ConsoleApp2.Enums;
using ConsoleApp2.Kontenery;
using ConsoleApp2.Ship;



bool CzyKoniec = false;

List<Ship> ShipList = new List<Ship>();
List<Kontener> KontenerList = new List<Kontener>();



void ShowShipList()
{
    Console.WriteLine("Lista kontenerowców:");
    if (ShipList.Count == 0)
    {
        Console.WriteLine("brak");
    }
    else
    {
        foreach (var Ship in ShipList)
        {
            Ship.showShip();
        }    
    }
    Console.WriteLine("\n");
}

void ShowKontenerList()
{
    Console.WriteLine("Lista kontenerów:");
    if (KontenerList.Count == 0)
    {
        Console.WriteLine("brak");
    }
    else
    {
        foreach (var kontener in KontenerList)
        {
            Console.WriteLine(kontener.ShowKontener());
        }
    }
    Console.WriteLine("\n");
}

void ShowMenu()
{
    Console.WriteLine("Możliwe akcje: ");
    Console.WriteLine("1. Dodaj kontenerowiec");
    Console.WriteLine("2. Dodaj kontener");
    Console.WriteLine("3. Załaduj kontener");
    Console.WriteLine("4. Wyładuj kontener");
    Console.WriteLine("5. Załaduj jeden kontener na statek");
    Console.WriteLine("6. Załaduj wszystkie kontenery na statek");
    Console.WriteLine("7. Wyładuj jeden kontener ze statku");
    Console.WriteLine("8. Wyładuj wszystkie kontenery ze statku");
    Console.WriteLine("9. Zastąp kontener na statku innym");
    Console.WriteLine("10. Przenieś kontener pomiędzy statkami");
    Console.WriteLine("11. Pokaż informacje o kontenerze");
    Console.WriteLine("12. Pokaż informacje o statku");
    Console.WriteLine("13. Pokaż informacje o statku i jego ładunku");
    Console.WriteLine("14. Wyjście");
    
    Console.WriteLine("\nWprowadz numer wybranej opcji: ");
}