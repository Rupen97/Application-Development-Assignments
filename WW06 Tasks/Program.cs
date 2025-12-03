using System;
using System.Collections.Generic;
using System.Linq;



using static Deligate;

class Program
{
    static void Main(string[] args)
    {
        //Task 1

        Console.WriteLine("Task 1");
        Rectangle rect = new Rectangle();

        rect.Length = 10;
        rect.Breadth = 5;

        Console.WriteLine("\nLength: " + rect.Length);
        Console.WriteLine("Breadth: " + rect.Breadth);

        Console.WriteLine("Area: " + rect.Area());
        Console.WriteLine("Perimeter: " + rect.Perimeter());


        //Task 2

        Console.WriteLine("\n\nTask 2");

        Calculate add = (a, b) => a + b;
        Calculate subtract = (a, b) => a - b;

        Console.WriteLine("\nAddition: " + add(5, 6));
        Console.WriteLine("Subtraction: " + subtract(9, 6));

        DiscountStrategy FestivalDiscount = (a) => a * 0.8;
        DiscountStrategy SeasonalDiscount = (a) => a * 0.9;
        DiscountStrategy NoDiscount = (a) => a;

        Console.WriteLine("\n20% Festival Discount for 1500: " + FestivalDiscount(1500));
        Console.WriteLine("10% Seasonal Discount for 1500: " + SeasonalDiscount(1500));
        Console.WriteLine("No Discount for 1500: " + NoDiscount(1500));

        //Task 2.1

        Console.WriteLine("\nCalling all Discounted final Pricec");

        //Task 2.2
        double originalPrice = 2500;
        Console.WriteLine("\nOriginal price: "+ originalPrice);
        Console.WriteLine("Final Price (Festival 20%): " + CalculateFinalPrice(originalPrice, FestivalDiscount));
        Console.WriteLine("Final Price (Seasonal 10%): " + CalculateFinalPrice(originalPrice, SeasonalDiscount));
        Console.WriteLine("Final Price (No Discount): " + CalculateFinalPrice(originalPrice, NoDiscount));

        // 2.3 - Lambda discount (30% off)
        double final30 = CalculateFinalPrice(originalPrice, (p) => p * 0.7);
        Console.WriteLine("Final Price (30% Discount): " + final30);


        //Task 3
        Console.WriteLine("\n\nTask 3");

        int[] numbers = { 4, 7, 12, 15, 20, 3, 8 };

        Console.WriteLine("Even Numbers:");
        ProcessNumbers(numbers, n => n % 2 == 0); // Condition for even numbers

        Console.WriteLine("\nNumbers Greater Than 10:");
        ProcessNumbers(numbers, n => n > 10); // Condition for numbers > 10


        //Task 4
        Console.WriteLine("\n\nTask 4");

        //Printing the square of each numbers in the list
        // Selecting / Projection
        List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5 };

        var squaredNumbers = numbers1.Select(n => n * n);

        Console.WriteLine("Squared Numbers:");
        foreach (var n in squaredNumbers)
        {
            Console.WriteLine(n);
        }

        //printing list of premium books
        BookStore store = new BookStore();
        store.ShowPremiumBooks();

        //sorting list of scholar students
        ScholarStudent scholar = new ScholarStudent();
        scholar.ShowSortedStudents();


        //Task 5 
        Console.WriteLine("\n\nTask 5");

        // Aggregation Operator
        List<CashierSales> salesList = new List<CashierSales>()
{
        new CashierSales { Name = "Ram", Sales = 1500 },
        new CashierSales { Name = "Sita", Sales = 2100 },
        new CashierSales { Name = "Hari", Sales = 1800 },
        new CashierSales { Name = "Gita", Sales = 2500 }
};

        Console.WriteLine("\nAggregation");
        Console.WriteLine($"Total Cashiers: {salesList.Count()}");
        Console.WriteLine($"Total Sales: {salesList.Sum(s => s.Sales)}");
        Console.WriteLine($"Highest Sale: {salesList.Max(s => s.Sales)}");
        Console.WriteLine($"Lowest Sale: {salesList.Min(s => s.Sales)}");
        Console.WriteLine($"Average Sale: {salesList.Average(s => s.Sales):F2}");

        // Quantifier Operators
        List<Applicant> applicants = new List<Applicant>()
{
        new Applicant { Name = "Anil", Age = 17 },
        new Applicant { Name = "Bina", Age = 19 },
        new Applicant { Name = "Chitra", Age = 15 },
        new Applicant { Name = "Deepak", Age = 20 }
};

        Console.WriteLine("\nQuantifier");
        Console.WriteLine($"Any applicant under 18? {applicants.Any(a => a.Age < 18)}");
        Console.WriteLine($"All applicants above 16? {applicants.All(a => a.Age > 16)}");

        // Element Operators
        List<Music> songs = new List<Music>()
{
        new Music { Title = "Song1", DurationSec = 200 },
        new Music { Title = "Song2", DurationSec = 300 },
        new Music { Title = "Song3", DurationSec = 450 },
        new Music { Title = "Song4", DurationSec = 650 },
        new Music { Title = "Song5", DurationSec = 800 }
};

        Console.WriteLine("\nElement Operators");
        var firstSong = songs.First();
        var lastSong = songs.Last();
        var firstAbove4Min = songs.First(s => s.DurationSec > 240); // >4 min
        var firstAbove10Min = songs.FirstOrDefault(s => s.DurationSec > 600); // >10 min

        Console.WriteLine($"First Song: {firstSong.Title}");
        Console.WriteLine($"Last Song: {lastSong.Title}");
        Console.WriteLine($"First Song > 4 min: {firstAbove4Min.Title}");
        Console.WriteLine($"First Song > 10 min: {(firstAbove10Min != null ? firstAbove10Min.Title : "None")}");


        //Task 6
        Console.WriteLine("\n\nTask 6");
        // Sample list of tour bookings
        List<TourBooking> bookings = new List<TourBooking>()
        {
            new TourBooking { CustomerName = "Ramesh", Destination = "Paris", Price = 15000, DurationInDays = 5, IsInternational = true },
            new TourBooking { CustomerName = "Sita", Destination = "Pokhara", Price = 8000, DurationInDays = 3, IsInternational = false },
            new TourBooking { CustomerName = "Hari", Destination = "Dubai", Price = 12000, DurationInDays = 6, IsInternational = true },
            new TourBooking { CustomerName = "Gita", Destination = "Chitwan", Price = 5000, DurationInDays = 2, IsInternational = false },
            new TourBooking { CustomerName = "Biren", Destination = "Thailand", Price = 11000, DurationInDays = 4, IsInternational = true }
        };

        // Filter: Tours above Rs. 10,000
        var expensiveTours = bookings.Where(t => t.Price > 10000);

        Console.WriteLine("Tours above Rs. 10,000:");
        foreach (var tour in expensiveTours)
        {
            Console.WriteLine($"{tour.CustomerName} = {tour.Destination} | Price: {tour.Price} | Duration: {tour.DurationInDays} days | International: {tour.IsInternational}");
        }

        // Filter: Tour duration more than 4 days
        var longTours = bookings.Where(t => t.DurationInDays > 4);

        Console.WriteLine("\nTours longer than 4 days:");
        foreach (var tour in longTours)
        {
            Console.WriteLine($"{tour.CustomerName} = {tour.Destination} | Price: {tour.Price} | Duration: {tour.DurationInDays} days | International: {tour.IsInternational}");
        }

        // Filter tours above 10,000 or longer than 4 days
        var filteredTours = bookings.Where(t => t.Price > 10000 || t.DurationInDays > 4);

        // Project into a new anonymous object with Category
        var projectedTours = filteredTours
            .Select(t => new
            {
                CustomerName = t.CustomerName,
                Destination = t.Destination,
                Category = t.IsInternational ? "International" : "Domestic",
                Price = t.Price,
                Duration = t.DurationInDays
            })
            // Sort by Category (Domestic first) and then by Price
            .OrderBy(t => t.Category)       
            .ThenBy(t => t.Price);

        // Display results in a clean format
        Console.WriteLine("\nFiltered and Sorted Tours:");
        foreach (var tour in projectedTours)
        {
            Console.WriteLine($"Customer: {tour.CustomerName} | Destination: {tour.Destination} | Category: {tour.Category} | Price: Rs.{tour.Price} | Duration: {tour.Duration} days");
        }

    }

    //method to calculate final price  task 2
    public static double CalculateFinalPrice(double originalPrice, DiscountStrategy strategy) => strategy(originalPrice);

    //method to convert list into numbers for task 3
    static void ProcessNumbers(int[] numbers, Func<int, bool> condition)
    {
        foreach (var number in numbers)
        {
            if (condition(number))
            {
                Console.WriteLine(number);
            }
        }
    }





}
