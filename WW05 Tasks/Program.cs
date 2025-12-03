//using System;

//class Program
//{
//    static void Main(string[] args)
//    {

//        //Task 1
//        Console.WriteLine("Task 1");
        
//        // Create a BankAccount object
//        BankAccount account = new BankAccount();

//        // Display account number
//        Console.WriteLine("\nAccount Number: " + account.AccountNumber);

//        // Deposit money
//        account.Deposit(500); // deposit 500
//        Console.WriteLine("Deposited: 500");

//        // Display balance
//        Console.WriteLine("Remaining Balance: " + account.Balance);

//        // Withdraw money
//        account.Withdraw(300); // withdraw 300
//        Console.WriteLine("\nWithdrawn: 300");

//        // Display remaining balance
//        Console.WriteLine("Remaining Balance: " + account.Balance);


//        //Task 2
//        Console.WriteLine("\n\nTask 2");

//        // Create Car object
//        Console.WriteLine("\nCar object");
//        Car car = new Car();
//        car.Brand = "Toyota";
//        car.Speed = "120km/hr";
//        car.Seats = 5;

//        car.Start();        // inherited from Vehicle
//        car.DisplayInfo();  // overridden
//        car.Stop();         // inherited from Vehicle

//        Console.WriteLine();

//        // Create Motorcycle object
//        Console.WriteLine("Motorcycle object");
//        Motorcycle bike = new Motorcycle();
//        bike.Brand = "Yamaha";
//        bike.Speed = "90km/Hr";
//        bike.CanRun = true;

//        bike.Start();        // inherited from Vehicle
//        bike.DisplayInfo();  // overridden
//        bike.Stop();         // inherited from Vehicle


//        //Task 3
//        Console.WriteLine("\n\nTask 3");

//        Printer p = new Printer();

//        // Calling Print(string)
//        p.Print("Hello, World!");

//        // Calling Print(int)
//        p.Print(12345);

//        // Calling Print(string, int)
//        p.Print("Hello repeat", 3);


//        //Task 4
//        Console.WriteLine("\n\nTask 4");

//        // Nepali Teacher
//        NepaliTeacher nt = new NepaliTeacher();
//        nt.Name = "Ramesh";
//        nt.Teaching();       // overridden
//        //nt.SalaryInfo();     // sealed, inherited only

//        Console.WriteLine();

//        // English Teacher
//        EnglishTeacher et = new EnglishTeacher();
//        et.Name = "Susan";
//        et.Teaching();        // uses base method
//                              //et.SalaryInfo();      // sealed method

//        // Car object
//        Console.WriteLine("\n");
//       Cars car1 = new Cars();
//        car1.Display();        // from abstract class
//        car1.StartEngine();    // implemented in Car
//        car1.StopEngine();     // implemented in Car

//        Console.WriteLine();

//        // Bike object
//        Bike bike1 = new Bike();
//        bike1.Display();        // from abstract class
//        bike1.StartEngine();    // implemented in Bike
//        bike1.StopEngine();     // implemented in Bike


//        //Task 5
//        Console.WriteLine("\n\nTask 5");

//        // Create store object
//        ElectronicsStore store = new ElectronicsStore();

//        // Create Laptop and Smartphone objects
//        Laptop laptop = new Laptop("Dell", 85000);
//        Smartphone phone = new Smartphone("Samsung", 45000);

//        // Add devices to store
//        store.AddDevice(laptop);
//        store.AddDevice(phone);

//        Console.WriteLine();

//        // Display all device details + downcasted special features
//        store.ShowAllDeviceDetails();
//    }
//}
