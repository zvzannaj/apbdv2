namespace ConsoleApp2;

public class CoolantCointainer : Container
{
    private PossibleProducts Product;
    private double Temperature;
    
    public CoolantCointainer(PossibleProducts product, double temperature, double cargoWeight, double height, double weight, double depth, string type, double capacity) : base(cargoWeight, height, weight, depth, type, capacity)
    {
        if (temperature < (double)product)
            throw new Exception();
        Temperature = temperature;
        Product = product;
    }
    
}