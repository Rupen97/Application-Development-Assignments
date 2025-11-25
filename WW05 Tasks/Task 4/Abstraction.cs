public abstract class Vehicles
{
    public abstract void StartEngine();
    public abstract void StopEngine();

    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}

public class Cars : Vehicles
{
    public override void StartEngine()
    {
        Console.WriteLine("Car engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Car engine stopped.");
    }
}

public class Bike : Vehicles
{
    public override void StartEngine()
    {
        Console.WriteLine("Bike engine started.");
    }

    public override void StopEngine()
    {
        Console.WriteLine("Bike engine stopped.");
    }
}
