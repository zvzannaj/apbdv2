namespace ConsoleApp2;

public class GasCointainer : Container,  IHazardNotifier
{
    public double Pressure;

    public GasCointainer(double cargoWeight, double height, double weight, double depth, double capacity,
        double pressure) : base(
        cargoWeight, height, weight, depth, "G", capacity)
    {
        Pressure = pressure;
    }
    public void Unload()
    {
        CargoWeight = 0.05 * CargoWeight;
    }
    
    public void Notify()
    {
        Console.WriteLine("Zaszła niebezpieczna sytuacja w kontenerze o numerze : " + SerialNumber);
    }
}