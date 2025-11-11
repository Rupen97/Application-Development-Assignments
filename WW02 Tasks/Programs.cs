
//using System.Collections.Generic;
//class Programs
//{
//    // Task 1
//    public static void Task1()
//    {
//        String username = "Rupen";
//        int luckyNumber = 100;
//        Console.WriteLine($"Hello, {username}! Your lucky number is {luckyNumber}");
//    }

//    // Task 2
//    public double CalculateArea(double r)
//    {
//        return r * r * Circle.pi;
//    }

//    public double CalculateParameter(double r)
//    {
//        return 2 * r * Circle.pi;
//    }

//    public static void Task2()
//    {
//        Programs program = new Programs();

//        double radius = 5;
//        double area = program.CalculateArea(radius);
//        double parameter = program.CalculateParameter(radius);

//        Console.WriteLine($"The area of Circle with radius {radius} is {area}");
//        Console.WriteLine($"The parameter of Circle with radius {radius} is {parameter}");
//    }

//    // Task 3
//    public static void Task3()
//    {
//        byte b = 25;
//        short sh = 12345;
//        int i = 42;
//        long l = 1234567890;
//        float f = 1.12f;
//        double d = 1.12345;
//        decimal dem = 12345.6789m;
//        char c = 'C';
//        bool bol = true;
//        string s = "3.14";

//        string intToString = i.ToString();
//        double stringTodouble = Convert.ToDouble(s);

//        Console.WriteLine($"Byte: {b}");
//        Console.WriteLine($"Short: {sh}");
//        Console.WriteLine($"Int: {i}");
//        Console.WriteLine($"Long: {l}");
//        Console.WriteLine($"Float: {f}");
//        Console.WriteLine($"Double: {d}");
//        Console.WriteLine($"Decimal: {dem}");
//        Console.WriteLine($"Char: {c}");
//        Console.WriteLine($"Bool: {bol}");
//        Console.WriteLine($"Int to String: {intToString}");
//        Console.WriteLine($"String to Double: {stringTodouble}");
//    }

//    // Task 4
 
//    public static void Task4()
//    {
//        int[] num = { 8, 9, 3, 1, 5, 2 };

//        Console.WriteLine($"Sorting number");
//        Array.Sort(num);

//        foreach (int n in num)
//        {
//            Console.WriteLine(n);
//        }

//        Console.WriteLine($"\nReverse number");
//        Array.Reverse(num);

//        foreach (int n in num)
//        {
//            Console.WriteLine(n);
//        }

//        Console.WriteLine($"\nIndex finder");

//        int number = 2;
//        int index = Array.IndexOf(num, number);

//        if (index != -1)
//            Console.WriteLine($"The number {number} is available at {index}");
//        else
//            Console.WriteLine($"The number {number} is not available in the array");
//    }
   

//    // Task 5
//    public static void Task5()
//    {
//        DateTime birthDate = new DateTime(2005, 8, 11);
//        DateTime current = DateTime.Now;
//        TimeSpan age = current - birthDate;

//        int ageInYears = (int)(age.TotalDays / 365.25);

//        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
//        Console.WriteLine($"Current date: {current.ToShortDateString()}");
//        Console.WriteLine($"My age: {ageInYears}");

//        DateTime newDate = birthDate.AddDays(10);
//        Console.WriteLine($"Birthdate after adding 10 days: {newDate.ToShortDateString()}");
//    }

//    // Task 6
//    public static void Task6()
//    {
//        List<string> fruits = new List<string>() { "Apple", "Banana", "Mango" };

//        fruits.Add("Orange");
//        fruits.Remove("Banana");

//        Console.WriteLine("Fruits in the list:");
//        foreach (string fruit in fruits)
//        {
//            Console.WriteLine(fruit);
//        }

//        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
//        {
//            { 1, "Mango" },
//            { 2, "Apple" },
//            { 3, "Orange" }
//        };

//        fruitDictionary.Add(4, "Banana");

//        Console.WriteLine("\nFruits in the dictionary:");
//        foreach (KeyValuePair<int, string> i in fruitDictionary)
//        {
//            Console.WriteLine($"ID: {i.Key}, Name: {i.Value}");
//        }
//    }

//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Task 1");
//        Task1();
//        Console.WriteLine($"\nTask 2");
//        Task2();
//        Console.WriteLine($"\nTask 3");
//        Task3();
//        Console.WriteLine($"\nTask 4");
//        Task4(); 
//        Console.WriteLine($"\nTask 5");
//        Task5();
//        Console.WriteLine($"\nTask 6");
//        Task6();
//    }
//}

//class Circle
//{
//    public const double pi = 3.14;
//}
