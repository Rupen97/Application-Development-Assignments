public class Laptop : ElectronicDevice
{
    // Constructor passing values to the base class
    public Laptop(string brand, double price) : base(brand, price)
    {
    }

    // Extra method
    public void TurnOnBattery()
    {
        Console.WriteLine("Laptop battery is now ON.");
    }

    // Override abstract method
    public override void ShowInfo()
    {
        Console.WriteLine("Laptop Information");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Price: ${Price}");
    }
}

public class Smartphone : ElectronicDevice
{
    // Constructor passing values to the base class
    public Smartphone(string brand, double price) : base(brand, price)
    {
    }

    // Extra method
    public void EnableCamera()
    {
        Console.WriteLine("Smartphone camera is now enabled.");
    }

    // Override abstract method
    public override void ShowInfo()
    {
        Console.WriteLine("Smartphone Information");
        Console.WriteLine($"Brand: {Brand}");
        Console.WriteLine($"Price: ${Price}");
    }
}
