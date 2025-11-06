//using System;

//class Program
//{
//    public static void Main(string[] Args)
//    {
//        int[] num = { 8, 9, 3, 1, 5, 2};

//        Console.WriteLine($"Sorting number");
//        for (int i = 0; i < num.Length - 1; i++)
//        {
//            for (int j = 0; j < num.Length - i - 1; j++)
//            {
//                if (num[j] > num[j + 1])
//                {
//                    int temp = num[j];
//                    num[j] = num[j + 1];
//                    num[j + 1] = temp;
//                }
//            }
//        }

//        for (int i = 0; i < num.Length; i++)
//        {
//            Console.WriteLine(num[i]);
//        }


//        Console.WriteLine($"\nReverse number");

//        for (int i =0; i < num.Length/2;  i++)
//        {
//            int temp = num[i];
//            num[i] = num[num.Length - i - 1];
//            num[num.Length -1 -i] = temp;
//        }

//        for (int i = 0; i < num.Length; i++)
//        {
//            Console.WriteLine(num[i]);
//        }

//        Console.WriteLine($"\nIndex finder");

//        int number = 2;
//        bool available = false;
//        int index = -1;

//        for (int i = 0;i < num.Length; i++)
//        {
//            if (num[i] == number)
//            {
//                available = true;
//                index = i;
//                break;
//            }
//        }

//        if (available)
//        {
//            Console.WriteLine($"The number {number} is available at {index}");
//        }
//        else
//        {
//            Console.WriteLine($"The number {number} is not available in the array");
//        }
//    }
//}


//class Program
//{
//    public static void Main(string[] args)
//    {
//        DateTime birthDate = new DateTime(2005, 8, 11);
//        DateTime current = DateTime.Now;
//        TimeSpan age = current - birthDate;

//        Console.WriteLine(age);

//        int ageInYears = (int)(age.TotalDays / 365.25);


//        Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
//        Console.WriteLine($"Current date: {current.ToShortDateString()}");
//        Console.WriteLine($"My age: {ageInYears}");

//        DateTime newDate = birthDate.AddDays(10);
//        Console.WriteLine($"Birthdate after adding 10 days: {newDate.ToShortDateString()}");
//    }
//}


using System.Collections.Generic; 

class Program
{
    public static void Main(string[] args)
    {
       
        List<string> fruits = new List<string>() { "Apple", "Banana", "Mango" };

        fruits.Add("Orange");

        fruits.Remove("Banana");

        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>()
        {
            { 1, "Mango" },
            { 2, "Apple" },
            { 3, "Orange" }
        };

        fruitDictionary.Add(4, "Banana");

        Console.WriteLine("\nFruits in the dictionary:");

        foreach (KeyValuePair<int, string> i in fruitDictionary)
        {
            Console.WriteLine($"ID: {i.Key}, Name: {i.Value}");
        }
    }
}
