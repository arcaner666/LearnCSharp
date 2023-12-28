namespace Example1;

internal abstract class Program
{
    /*
    Bir sınıf yalnızca tek bir sınıftan miras alabilir. Fakat birden fazla sayıda arayüz implement edebilir.
    */
    private interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    private class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    private class Manager : Person, IPerson
    {
        public int NumberOfDirectReports { get; set; }
    }

    private static void Main(string[] args)
    {
        var manager = new Manager
        {
            FirstName = "Arcan Caner",
            LastName = "Şenol",
            Age = 28,
            NumberOfDirectReports = 2,
        };
        Console.WriteLine($"My name is {manager.FirstName} {manager.LastName} and I am {manager.Age} years old. My report count is {manager.NumberOfDirectReports}");
    }
}