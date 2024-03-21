﻿namespace ConsoleApp2;

public class ContainerShip
{
    public double MaxSpeed { get; set; }
    public List<Container> AllContainers  { get; set; }
    public int MaxAmount { get; set; }
    public double MaxWeight { get; set; }
    public double CurrentWeight;

    public ContainerShip(double maxSpeed, double maxWeight, int maxAmount)
    {
        AllContainers = new List<Container>();
        MaxSpeed = maxSpeed;
        MaxAmount = maxAmount; 
        MaxWeight = maxWeight;
    }

    public void Load(Container con)
    {   
        if(MaxAmount<AllContainers.Count+1)
        { 
        Console.WriteLine("Maksymalna ilość kontenerów została przekroczona");
        }
        else if (MaxWeight*1000 < (con.CargoWeight + con.CargoWeight +CurrentWeight))
        {
            Console.WriteLine("Maksymalna waga statku została przekroczona");
        }
        else
        {
        AllContainers.Add(con);
        CurrentWeight += con.CargoWeight + con.CargoWeight;  
        }
    }

    public void Load(List<Container> list)
    {
       double listWeight = 0;
       for (int i = 0; i < list.Count; i++)
       { listWeight += (list[i].CargoWeight + list[i].CargoWeight);}
        
        if(list.Count>MaxAmount-AllContainers.Count)
        { 
            Console.WriteLine("Maksymalna ilość kontenerów została przekroczona");
        }
        else if (MaxWeight*1000 < listWeight+CurrentWeight)
        {
            Console.WriteLine("Maksymalna waga statku została przekroczona");
        }
        else
        {
            AllContainers.AddRange(list);
            CurrentWeight += listWeight;  
        }
    }
    
    
    public void Remove(String seriesNumber)
    {
        for (int i = 0; i <AllContainers.Count; i++)
        {
            if (AllContainers[i].SerialNumber == seriesNumber)
            {
                Console.WriteLine("Usunieto "+AllContainers[i].SerialNumber+" kontener ");
                AllContainers.RemoveAt(i);
                break;
            } 
        }
    }

    public void Replace(String seriesNumber,Container con)
    {
        for (int i = 0; i < AllContainers.Count; i++)
        {
            if (AllContainers[i].SerialNumber == seriesNumber)
            {
                Console.WriteLine("Zastopiono "+AllContainers[i].SerialNumber+" kontenerem "+con.SerialNumber);
                AllContainers[i] = con;
                break;
            }
    }  
    }

    public void Move(ContainerShip cs,Container con)
    { 
    Load(con);
    if (AllContainers.Contains(con)) //czy sie zmiescil
    {
        cs.Remove(con.SerialNumber);
        Console.WriteLine("Przeniesiono kontener z sukcesem");
    } 
    }
    

    public override string ToString()
    {
        string allcons = "";
        for (int i = 0; i < AllContainers.Count; i++) allcons += AllContainers[i].SerialNumber+" | ";
        return "Statek - Max Waga: " + MaxWeight + " ton | Max predkosc: " + MaxSpeed + " wezlow | Max ilosci kontenerow " +
               MaxAmount+ "  -> wiezie kontenery : "+allcons;
    }
}