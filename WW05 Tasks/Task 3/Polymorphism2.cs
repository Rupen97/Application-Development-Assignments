public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    // This method CANNOT be overridden
    //public sealed void SalaryInfo()
    //{
    //    Console.WriteLine("Teacher's salary information.");
    //}
}

public class NepaliTeacher : Teacher
{
    public override void Teaching()
    {
        Console.WriteLine("Nepali Teacher teaches in Nepali language.");
    }
}

public class EnglishTeacher : Teacher
{
    // No override needed teaching() method
}
