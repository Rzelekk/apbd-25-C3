
using ConsoleApp2.Enums;
using ConsoleApp2.Kontenery;
using ConsoleApp2.Ship;

// Ship ship = new Ship("Ship1",10,10,5);
//
//
// List<Kontener> kontenerToLoad = new List<Kontener>();
//
// LiquidKontener liquidKontener = new LiquidKontener(1204, 670, 450, 567);
// LiquidKontener liquidHazardKontener = new LiquidKontener(1204, 670, 450, 987);
// GasKontener gasKontener = new GasKontener(1000,50,100,600);
// RefrigeratedKontener refrigeratedKontener = new RefrigeratedKontener(2351, 218, 732, 763);
// liquidKontener.Load(566);
// liquidHazardKontener.Load(326, true);
// gasKontener.Load(124);
// refrigeratedKontener.Load(653,Products.FrozenPizza);
//
// kontenerToLoad.Add(liquidKontener);
// kontenerToLoad.Add(liquidHazardKontener);
// kontenerToLoad.Add(gasKontener);
// kontenerToLoad.Add(refrigeratedKontener);
//
// // ship.LoadContainer(gasKontener);
// ship.LoadContainer(kontenerToLoad);
//
// ship.ShowLadunek();
//
// LiquidKontener liquidKontener2 = new LiquidKontener(1204, 670, 450, 567);
//
// ship.SwapKonteners(liquidKontener2, "KON-C-423");
// // ship.KontenerList[0].Unload();
//
// ship.ShowLadunek();
//
// Console.WriteLine(liquidKontener2.ShowKontener());
//
// ship.showShip();

bool CzyKoniec = false;
int KontenerIndex;
int ShipIndex;
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
            Console.WriteLine("Podaj numer kontenera: ");
            
            KontenerIndex = KontenerList.FindIndex(k => k.NumerSeryjny == Console.ReadLine());
    
            if(KontenerIndex == -1)
            {
                Console.WriteLine($"Nie można znaleźć kontenera o numerze seryjnym {KontenerIndex}.");
            }
            else
            {
                Console.WriteLine("Podaj masę ładunku w kg: ");
                double masaLadunku = Convert.ToDouble(Console.ReadLine());
                
                switch (KontenerList[KontenerIndex].Typ)
                {
                    case "L":
                        Console.WriteLine("Czy jest to ładunek niebezpieczny (true/false)");
                        String t = Console.ReadLine();
                        if (t == "true" || t == "false")
                        {
                            
                        }
                        else
                        {
                            Console.WriteLine("nie poprawna wartość");
                        }
                        break;
                    case "G":
                        
                        break;
                    case "C":
                        
                        break;
                    default:
                        Console.WriteLine("Podany typ kontenera jest nieprawidłowy");
                        break;
                }
                KontenerList[KontenerIndex].ShowKontener();
            }
            break;
        case 4:
            Console.WriteLine("Podaj numer kontenera: ");
            
            KontenerIndex = KontenerList.FindIndex(k => k.NumerSeryjny == Console.ReadLine());
    
            if(KontenerIndex == -1)
            {
                Console.WriteLine($"Nie można znaleźć kontenera o numerze seryjnym {KontenerIndex}.");
            }
            else
            {
                KontenerList[KontenerIndex].Unload();
            }
            break;
        case 5:
            Console.WriteLine("Podaj nazwę statku: ");
            
            ShipIndex = ShipList.FindIndex(k => k.Nazwa == Console.ReadLine());
            
            if(ShipIndex == -1)
            {
                Console.WriteLine($"Nie można znaleźć statku o nazwie: {ShipIndex}.");
            }
            else
            {
                Console.WriteLine("Podaj numer kontenera: ");
            
                KontenerIndex = KontenerList.FindIndex(k => k.NumerSeryjny == Console.ReadLine());
    
                if(KontenerIndex == -1)
                {
                    Console.WriteLine($"Nie można znaleźć kontenera o numerze seryjnym {KontenerIndex}.");
                }
                else
                {
                    ShipList[ShipIndex].LoadContainer(KontenerList[KontenerIndex]);
                }
            }
            break;
        case 6:
            Console.WriteLine("Podaj nazwę statku: ");
            
            ShipIndex = ShipList.FindIndex(k => k.Nazwa == Console.ReadLine());
    
            if(ShipIndex == -1)
            {
                Console.WriteLine($"Nie można znaleźć statku o nazwie: {ShipIndex}.");
            }
            else
            {
                ShipList[ShipIndex].LoadContainer(KontenerList);
            }
            break;
        case 7:
            
            break;
        case 8:
            Console.WriteLine("Podaj nazwę statku: ");
            
            ShipIndex = ShipList.FindIndex(k => k.Nazwa == Console.ReadLine());
    
            if(ShipIndex == -1)
            {
                Console.WriteLine($"Nie można znaleźć statku o nazwie: {ShipIndex}.");
            }
            else
            {
                ShipList[ShipIndex].UnloadAllFromShip();
            }
            break;
        case 9:
            
            break;
        case 10:
            
            break;
        case 11:
            Console.WriteLine("Podaj numer kontenera: ");
            
            KontenerIndex = KontenerList.FindIndex(k => k.NumerSeryjny == Console.ReadLine());
    
            if(KontenerIndex == -1)
            {
                Console.WriteLine($"Nie można znaleźć kontenera o numerze seryjnym {KontenerIndex}.");
            }
            else
            {
                KontenerList[KontenerIndex].ShowKontener();
            }
            break;
        case 12:
            Console.WriteLine("Podaj nazwę statku: ");
            
            int indexStatku = ShipList.FindIndex(k => k.Nazwa == Console.ReadLine());
    
            if(indexStatku == -1)
            {
                Console.WriteLine($"Nie można znaleźć statku o nazwie: {indexStatku}.");
            }
            else
            {
                ShipList[indexStatku].showShip();
            }
            break;
        case 13:
            Console.WriteLine("Podaj nazwę statku: ");
            
            int indexStatku2 = ShipList.FindIndex(k => k.Nazwa == Console.ReadLine());
    
            if(indexStatku2 == -1)
            {
                Console.WriteLine($"Nie można znaleźć statku o nazwie: {indexStatku2}.");
            }
            else
            {
                ShipList[indexStatku2].showShip();
                ShipList[indexStatku2].ShowLadunek();
            }
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