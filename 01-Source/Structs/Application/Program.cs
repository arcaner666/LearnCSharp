namespace Application;

internal abstract class Program
{
    /*
    C#'ta yapı (struct) çoğu bakımdan sınıflara (classes) benzer. Aynı sınıflar gibi içerisinde veri yapıları taşıyan üyeler (members) ve metotlar (methods) barındırabilir. Ancak
    sınıfların aksine yapılar değer tiplerdir (value types) ve heap allocation'a ihtiyaç duymazlar. Yapı türündeki bir değişken direk içerinde değerin kendisini tutar. Sınıflar ise 
    içerisinde bu değeri tutan nesnelerin referansını tutar.

    C#'taki basit tiplerin (simple types) hepsi birer yapıdır.
    - sbyte
    - byte
    - short
    - ushort
    - int
    - uint
    - long
    - ulong
    - char
    - float
    - double
    - bool
    - decimal

    Yapılar başka bir yapıdan miras alamazlar. Sadece arayüzleri implement edebilirler.
    */
    private struct Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    private static void Main(string[] args)
    {
        var person = new Person("Arcan Caner", "Şenol");
        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
    }
}