namespace Application;

internal abstract class Program
{
    /*
    Kayıtlar (record) C#'ta değiştirilemeyen veri yapıları (immutable data types) oluşturmak istendiğinde kullanılır. Sınıflardan farklı olarak eşitlik kontrollerinde değer eşitliğini 
    (value equality) destekler. Fakat istersek üyelerinin değiştirilebilir olması da sağlanabilir.

    Kayıtlar sadece kayıtlardan miras alabilir. Sınıf veya yapılardan miras alamazlar. Fakat arayüzleri implemente edebilirler.
    */
    private record Person
    {
        // Buradaki init deyimi sayesinde sadece nesne oluşturma (object initialization) aşamasında bu üyelere atama yapılmasına izin veririz.
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public int Age { get; init; }
    }

    private static void Main(string[] args)
    {
        var person = new Person
        {
            FirstName = "Arcan Caner",
            LastName = "Şenol",
            Age = 28
        };
        Console.WriteLine($"My name is {person.FirstName} {person.LastName} and I am {person.Age} years old.");
    }
}