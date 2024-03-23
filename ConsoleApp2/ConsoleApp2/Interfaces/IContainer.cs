namespace ConsoleApp2.Interfaces;

public interface IContainer
{
    void Unload();
    void Unload(double weight);
    void Load(double cargoWeight);
}