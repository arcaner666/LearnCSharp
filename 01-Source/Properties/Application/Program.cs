namespace Application;

internal abstract class Program
{
    /*
    C#'ta özellik (property), alanların (fields) genişletilmiş halidir.
    */
    private class Person
    {
        // Özellikler alltaki gibi de tanımlanabilir. Bu durumda private alanı, get ve set metotlarını derleyici arkada bizim için tanımlar.
        public string FirstName { get; set; } = "Arcan Caner";

        // Özellikleri alltaki gibi manuel olarak da tanımlayabiliriz. Üstteki özellik tanımlama şekli ile alttaki arka planda aynı şekilde çalışır.
        public string LastName
        {
            get => _lastName;
            set => _lastName = value;
        }
        private string _lastName = "Şenol";
    }
    private static void Main(string[] args)
    {
        var person = new Person();
        Console.WriteLine(person.FirstName);
        Console.WriteLine(person.LastName);
    }
}