namespace Application;

internal abstract class Program
{
    /*
    C#'ta bir arayüz (interface) bir sözleşmeyi tanımlar. Bir arayüzü implemente eden bir sınıf (class) ya da yapı (struct) sözleşmeye bağlı kalmaya çalışır. Yani arayüzde tanımlanan
    tüm üyeler implement edilen sınıf ya da yapıda bulunmak zorundadır. Bir arayüz birden fazla arayüzden türetilebilir ve bir sınıf ya da yapı birden fazla arayüzü implemente edebilir.
    
    Arayüzler metotlar (methods), özellikler (properties), olaylar (events) ve sıralayıcıları (indexers) içerebilir. Arayüzün kendisi içerisinde tanımlanan üyelerin (member) nasıl
    implemente edileceklerini tanımlamaz. Yalnızca kendisini implement edecek olan arayüzler, sınıflar ve yapılar için zorunlu olarak implemente edilecek üyeleri belirtir.
    */

    /*
    Alttaki Person sınıfı IPerson arayüzünü implemente etmiştir. Bu sebeple IPerson içerisinde tanımlanan tüm üyeler aynı zamanda Person içerisinde de tanımlanmak zorundadır.
    */
    private interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    private class Person : IPerson
    {
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
        var person = new Person("Arcan Caner", "Şenol", 28);
        Console.WriteLine($"My name is {person.FirstName} {person.LastName} and I am {person.Age} years old.");
    }
}