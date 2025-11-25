
public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    // Add device to store
    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine($"{device.Brand} added to store.");
    }

    // Remove device from store
    public void RemoveDevice(ElectronicDevice device)
    {
        if (devices.Remove(device))
        {
            Console.WriteLine($"{device.Brand} removed from store.");
        }
        else
        {
            Console.WriteLine("Device not found in store.");
        }
    }

    // Show details of all devices
    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n=== All Device Details ===");

        foreach (var device in devices)
        {
            device.ShowInfo();   // Polymorphism

            // Downcasting to call child-specific methods
            if (device is Laptop laptop)
            {
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone smartphone)
            {
                smartphone.EnableCamera();
            }

            Console.WriteLine();
        }
    }
}
