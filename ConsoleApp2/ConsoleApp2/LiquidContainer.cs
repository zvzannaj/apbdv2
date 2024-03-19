﻿namespace ConsoleApp2;

public class LiquidContainer : Container, IHazardNotifer
{
    private bool IsSafe;
    public LiquidContainer(double cargoWeight, double height, double weight, double depth, double capacity, bool isSafe) : base(cargoWeight, height, weight, depth, "L", capacity)
    {
        IsSafe = isSafe;
    }
    
    public override void Load(double cargoWeight)
    {
        if (IsSafe)
        {
            if (cargoWeight <= 0.9 * Capacity)
                base.Load(cargoWeight);
            else ;
        }
        else
        {
            if (cargoWeight <= 0.5 * Capacity)
                base.Load(cargoWeight);
            else ;
        }
    }

    public void Notify()
    {
       Console.WriteLine("Zaszła niebezpieczna sytuacja w kontenerze o numerze : " + SerialNumber);
        
    }
}

