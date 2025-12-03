using System.Collections.Generic;
using System.Linq;

public class BookItem   
{
    public string Title { get; set; }
    public int Price { get; set; }
}

public class BookStore
{
    public List<BookItem> books = new List<BookItem>()
    {
        new BookItem { Title = "Data and web development", Price = 850 },
        new BookItem { Title = "AI", Price = 1500 },
        new BookItem { Title = "App development", Price = 1200 },
        new BookItem { Title = "Database", Price = 950 }
    };

    public void ShowPremiumBooks()
    {
        var premiumBooks = books.Where(b => b.Price > 1000);

        Console.WriteLine("\nPremium Books (Price > 1000):");
        foreach (var b in premiumBooks)
        {
            Console.WriteLine($"{b.Title} - Rs. {b.Price}");
        }
    }
}

public class StudentProp
{
    public string Name { get; set; }
}

public class ScholarStudent
{
    public List<StudentProp> students = new List<StudentProp>()
    {
        new StudentProp { Name = "Ramesh" },
        new StudentProp { Name = "Aayush" },
        new StudentProp { Name = "Kritika" },
        new StudentProp { Name = "Biren" },
        new StudentProp { Name = "Sushmita" }
    };

    public void ShowSortedStudents()
    {
        var sortedStudents = students.OrderBy(s => s.Name);

        Console.WriteLine("\nStudents Sorted Alphabetically:");
        foreach (var s in sortedStudents)
        {
            Console.WriteLine(s.Name);
        }
    }
}
