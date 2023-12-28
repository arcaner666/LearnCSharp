namespace Application;

internal abstract class Program
{
    /*
    C#'ta bir sınıf (class) veya yapı (struct) oluşturulduğunda onun örnek oluşturucusu (instance constructor) çağrılır. Bir sınıf veya yapının farklı parametreler alan birden
    fazla örnek oluşturucusu olabilir. Örnek oluşturucular programcılara varsayılan değerleri ayarlamak, başlangıç limitleri oluşturmak, koda esneklik sağlamak ve kod
    okunabilirliğini arttırmasını sağlar.

    Bir sınıf veya yapı içerisinde hiçbir örnek oluşturucu eklemesek bile derleyici parametresiz bir örnek oluşturucuyu o sınıf veya yapıya derleme işleminde otomatik olarak ekler. 
    Eğer bir sınıf veya yapıda kendimiz parametreli bir örnek oluşturucu yaratırsak bu otomatik ekleme özelliği devre dışı kalır. Artık o nesnenin her örneği oluşturulmaya çalışıldığında 
    örnek oluşturucuya bu parametreleri girmek zorunda kalırız. Bunu engellemek için parametresiz bir örnek oluşturucu ekleyebiliriz.
    */
    private interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    private class Employee : IPerson
    {
        // Örnek oluşturucu içinde bulunduğu sınıf veya yapıyla aynı adı taşımalıdır. Yazım olarak sadece opsiyonel erişim bildirgeci alır. Dönüş tipi içeremez. 
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
        // Birbirinden türetilen sınıflarda base deyimi ile temel sınıfın örnek oluşturucusuna ihtiyacı olan parametreleri gönderebiliriz. Burada base deyimi temel sınıfın örnek
        // oluşturucusunu çağırır.
        public Manager(string firstName, string lastName, int age) : base(firstName, lastName, age)
        {
        }
    }

    private static void Main(string[] args)
    {
        /*
        Employee adından sonra gelen () işaretlerine ise örnek oluşturucu (instance constructor) denir. Bir örnek oluşturucuya bir parametre tanımlandığında artık o sınıftan 
        oluşturulan tüm örneklere o parametre girilmek zorunda olur.
        */
        var employee = new Employee("Yaşar Taner", "Şenol", 20);
        var manager = new Manager("Arcan Caner", "Şenol", 28);
        Console.WriteLine($"My name is {employee.FirstName} {employee.LastName} and I am {employee.Age} years old.");
        Console.WriteLine($"My name is {manager.FirstName} {manager.LastName} and I am {manager.Age} years old.");
    }
}