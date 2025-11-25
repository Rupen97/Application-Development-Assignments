public abstract class ElectronicDevice
{
    private string brand;
    private double price;

    // Encapsulated brand property
    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    // Encapsulated price property
    public double Price
    {
        get { return price; }
        set { price = value; }
    }

    // Constructor to initialize brand and price
    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }

    // Abstract method
    public abstract void ShowInfo();
}
