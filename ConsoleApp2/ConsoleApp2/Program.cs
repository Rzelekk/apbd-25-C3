
using ConsoleApp2.Enums;
using ConsoleApp2.Kontenery;
using ConsoleApp2.Ship;



bool CzyKoniec = false;

List<Ship> ShipList = new List<Ship>();
List<Kontener> KontenerList = new List<Kontener>();


while (!CzyKoniec)
{
    ShowShipList();
    ShowKontenerList();
    ShowMenu();

    switch (Convert.ToInt32(Console.ReadLine()))
    {
        case 1:
            Console.WriteLine("Podaj nazwę statku:");
            string nazwa = Console.ReadLine();

            Console.WriteLine("Podaj maksymalną liczbę kontenerów:");
            int maxKontenerCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj maksymalne obciążenie kontenerów:");
            int maxKontenerLoad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Podaj maksymalną prędkość:");
            double maxSpeed = Convert.ToDouble(Console.ReadLine());

            ShipList.Add(new Ship(nazwa, maxKontenerCount, maxKontenerLoad, maxSpeed));
            break;
        case 2:
            Console.WriteLine("Podaj typ kontenera:");
            string typ = Console.ReadLine();

            Console.WriteLine("Podaj masę własną kontenera:");
            double masaWlasna = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj wysokość kontenera:");
            double wysokosc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj głębokość kontenera:");
            double glebokosc = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Podaj maksymalną masę ładunku kontenera:");
            double maxMasaLadunku = Convert.ToDouble(Console.ReadLine());

            switch (typ)
            {
                case "L":
                    KontenerList.Add(new LiquidKontener(masaWlasna, wysokosc, glebokosc, maxMasaLadunku));
                    break;
                case "G":
                    KontenerList.Add(new GasKontener(masaWlasna, wysokosc, glebokosc, maxMasaLadunku));
                    break;
                case "C":
                    KontenerList.Add(new RefrigeratedKontener(masaWlasna, wysokosc, glebokosc, maxMasaLadunku));
                    break;
                default:
                    Console.WriteLine("Podany typ kontenera jest nieprawidłowy");
                    break;
            }
            break;
        case 3:
            
            break;
        case 4:
            
            break;
        case 5:
            
            break;
        case 6:
            
            break;
        case 7:
            
            break;
        case 8:
            
            break;
        case 9:
            
            break;
        case 10:
            
            break;
        case 11:
            
            break;
        case 12:
            
            break;
        case 13:
            
            break;
        case 14:
            CzyKoniec = true;
            break;
        default:
            Console.WriteLine("Nie ma opcji o takim numerze");
            break;
    }
    
}

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