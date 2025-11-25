public class Printer
{
    // Print a string message
    public void Print(string message)
    {
        Console.WriteLine("\nMessage: " + message);
    }

    // Print an integer number
    public void Print(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    // Print a message multiple times
    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine((i + 1) + ". " + message);
        }
    }
}
