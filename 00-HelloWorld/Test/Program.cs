namespace Test;

internal abstract class Program
{
    private interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    private class Employee : IPerson
    {
        public Employee(string firstName, string lastName, int age)
        {

            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    private class Manager : Employee, IPerson
    {
        public Manager(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }
    }

    private static void Main(string[] args)
    {

        var employee = new Employee("Yaşar Taner", "Şenol", 20);
        var manager = new Manager("Arcan Caner", "Şenol", 28);
        Console.WriteLine($"My name is {employee.FirstName} {employee.LastName} and I am {employee.Age} years old.");
        Console.WriteLine($"My name is {manager.FirstName} {manager.LastName} and I am {manager.Age} years old.");
    }
}