using System.Diagnostics;

public class Vehicle
{
    public string Brand { get; set; }
    public string Speed { get; set; }

    public void Start()
    {
        Console.WriteLine("Start the vechile");
    }
    public void Stop()
    {
        Console.WriteLine("*stops the vechile*");
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine("*Display Info of vechile*");
    }
}

public class Car : Vehicle
{
    public int Seats { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Seats: {Seats}");
    }
}


public class Motorcycle : Vehicle
{
    public bool CanRun { get; set; }
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Can run: {CanRun}");
    }
}
