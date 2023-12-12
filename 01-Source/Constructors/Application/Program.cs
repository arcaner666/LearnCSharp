namespace Application;

internal abstract class Program
{
    private class Person
    {
        /*
        Alttaki yapıya örnek oluşturucu (instance constructor) denir. Örnek oluşturucular içlerine parametreler alırlar. Burada gelen parametreler içerdeki özelliklere atanmış.
        */
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    private static void Main(string[] args)
    {
        /*
        Person adından sonra gelen () işaretlerine ise örnek oluşturucu (instance constructor) denir. Bir örnek oluşturucuya bir parametre tanımlandığında artık o sınıftan 
        oluşturulan tüm örneklere o parametre girilmek zorunda olur.
        */
        var person = new Person("Arcan Caner", "Şenol", 28);
        Console.WriteLine($"My name is {person.FirstName} {person.LastName} and I am {person.Age} years old.");
    }
}