namespace ConsoleApp2;

public abstract class Container : IContainer
{
    public double CargoWeight { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public double Depth { get; set; }
    private static int Count;
    public string SerialNumber;
    public double Capacity;
    protected Container(double cargoWeight, double height, double weight, double depth, string type, double capacity)
    {
        CargoWeight = cargoWeight;
        Height = height;
        Weight = weight;
        Depth = depth;
        SerialNumber = "KON-" + type + " " + Count;
        Capacity = capacity;
    }


    public void Unload()
    {
        CargoWeight = 0.0;
    }

    public virtual void Load(double cargoWeight)
    {
        if (cargoWeight > Capacity)
        {
            throw new OverfillException();
        }

        CargoWeight = cargoWeight;
    }
}