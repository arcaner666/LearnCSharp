#region Üyeler (Members)

#region Genel
/*
Ad uzayları (namespace) ve türlerin (types) üyeleri (members) vardır. Bir varlığın üyesine erişmek için genel olarak entity adından sonra bir . konur ardından 
üyenin adı yazılır. Bu şekilde bir varlığın üyesine erişiriz.

Bir türün üyeleri ya türün içerisinde ya da bu türün temel sınıfında tanımlanır. Bir tür temel sınıfından miras aldığında, örnek oluşturucular (instance constructors),
sonlandırıcılar (finalizers) ve statik oluşturucular (static constructors) dışında temel sınıfın tüm üyeleri, türetilen türün üyeleri haline gelir.

Bir temel sınıftaki üyenin erişim bildirgeci (access modifier), üyenin miras alınıp alınmadığını denetlemez. Erişim bildirgeçleri örnek oluşturucu, statik oluşturucu
veya sonlandırıcı hariç geri kalan tüm üyelere yayılır.

Yine de, temel bir sınıf içerisindeki bir üyeye üzerinde tanımlanan erişim bildirgeci sebebiyle türetildiği sınıftan erişilemeyebilir. 
*/

//public class Person
//{
//    public string NameSurname { get; set; }
//    public int Age { get; set; }
//    private DateOnly BirthDate { get; set; }
//    public Person(string nameSurname, int age)
//    {
//        NameSurname = nameSurname;
//        Age = age;
//    }

//    public void ShowMyNameAndAge()
//    {
//        Console.WriteLine($"{NameSurname} is {Age} years old.");
//    }
//}

//// Person sınıfından miras alındığından ve NameSurname, Age, ShowMyNameAndAge üyelerinin erişim bildirgeci public olduğundan bunlar Customer sınıfına aktarılmıştır.
//// BirthDate üyesinin erişim bildirgeci private olduğundan aktarılmamıştır.
//public class Customer : Person
//{
//    // Bu sadece Customer sınıfında bulunan bir alandır. Sadece Customer sınıfında tanımlandığı için Person sınıfında bulunmaz.
//    public int OrderCount { get; set; }
//    // base deyimiyle türetilmiş sınıfımızın örnek oluşturucusundan (instance constructor) temel sınıfımızın örnek oluşturucusuna veri göndeririz.
//    public Customer(string nameSurname, int age, int orderCount) : base(nameSurname, age)
//    {
//        OrderCount = orderCount;
//    }
//}

//namespace Application
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var person = new Person("Arcan Caner Şenol", 28);
//            //person.BirthDate = DateOnly.Parse("1995-01-01"); // BirthDate alanı private olduğundan Person sınıfından miras alan Customer sınıfından erişilemez.
//            Console.WriteLine($"Name Surname: {person.NameSurname}");
//            Console.WriteLine($"Age: {person.Age}");
//            person.ShowMyNameAndAge();

//            Console.WriteLine("------------------------------");

//            var customer = new Customer("Yaşar Taner Şenol", 21, 5);// Örnek oluşturucular miras alınmadığından ikisi sınıf farklı bilgiler içerebilir.
//            Console.WriteLine($"Name Surname: {customer.NameSurname}");
//            Console.WriteLine($"Age: {customer.Age}");
//            Console.WriteLine($"Name Surname: {customer.OrderCount}");
//            customer.ShowMyNameAndAge();
//        }
//    }
//}
#endregion

#region Ad Uzayı Üyeleri (Namespace Members)
/*
Ad uzayları (namespaces) ve herhangi bir ad uzayının içerisinde bulunmayan tüm türler (types) küresel ad uzayının (global namespace) üyeleridir.

Bir ad uzayı içinde bildirilen ad uzayları ve türler, o ad uzayının üyeleridir.

Ad uzaylarının erişim kısıtlaması yoktur. Ad uzaylarında private, protected, internal gibi erişim bildirgeçleri tanımlanamaz. Ad uzayları her zaman erişime açıktır.

!!! Yorum satırını kaldırmadan incele ReSharper ad uzaylarını birleştiriyor çünkü. !!!
*/


//public class Person1
//{
//    public string NameSurname { get; set; } = "Arcan Caner Şenol";
//}

//namespace N1
//{
//    public class Person2
//    {
//        public string NameSurname { get; set; } = "Yaşar Taner Şenol";
//    }
//}

//namespace Application
//{

//    public class Person3
//    {
//        public string NameSurname { get; set; } = "Dilara Şenol";
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Person1 sınıfı Küresel tanım uzayında (global namespace) tanımlandığı için her yerden ve önüne herhangi bir ad uzayı eklemeden erişilebiliyor.
//            var person1 = new Person1();
//            Console.WriteLine($"Name Surname: {person1.NameSurname}");

//            // Person2 sınıfı N1 ad uzayından tanımlı bu sebeple erişmek için ad uzayının adını da sınıf isminin önüne eklemek gerekiyor.
//            var person2 = new N1.Person2();
//            Console.WriteLine($"Name Surname: {person2.NameSurname}");

//            // Person3 sınıfı Main metoduyla aynı ad uzayında tanımlı bu sebeple buradan erişilebiliyor.
//            var person3 = new Person3();
//            Console.WriteLine($"Name Surname: {person3.NameSurname}");
//        }
//    }
//}
#endregion

#region Yapı Üyeleri (Struct Members)
/*
Bir yapının (struct) üyeleri yapı içerisinde tanımlanan üyeler, yapının direk temel sınıfı (direct base class) olan System.ValueType ve dolaylı temel sınıfı olan
(indirect base class) object üyelerinden oluşur.

Basit bir türün (simple type) üyeleri, basit tür (§8.3.5) tarafından takma ad (alias) verilen yapı türünün üyelerine doğrudan karşılık gelir.
*/

//namespace Application
//{
//    public struct Person
//    {
//        public string NameSurname { get; set; }

//        public Person(string nameSurname)
//        {
//            NameSurname = nameSurname;
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var person = new Person("Arcan Caner Şenol");
//            // Burada yapı içerisinde tanımlanan NameSurname alanına erişilmiştir.
//            Console.WriteLine($"Name Surname: {person.NameSurname}");
//        }
//    }
//}
#endregion

#endregion