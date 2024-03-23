namespace ConsoleApp2.Interfaces;

public interface IHazardNotifier
{
    public static void HazardNotification(String contenerSerial, String tekst)
    {
        Console.Error.WriteLine("---NIEBEZPIECZEŃSTWO---");
        Console.Error.WriteLine($"Kontener {contenerSerial} -> {tekst}");
    }
}