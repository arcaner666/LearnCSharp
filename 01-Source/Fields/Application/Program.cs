namespace Application;

internal abstract class Program
{
    /*
    C#'ta alan (field) bir sınıf (class) veya yapı (struct) içerisinde tanımlanan tüm tiplere (types) denir. Alanlar onları kapsayan tipin (containing types) üyeleridirler (members).
    */
    private class Person
    {
        public string firstName = "Arcan Caner Şenol";
    }
    private static void Main(string[] args)
    {
        var person = new Person();
        Console.WriteLine(person.firstName);
    }
}