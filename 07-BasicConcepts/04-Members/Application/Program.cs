#region Üyeler (Members)

#region Genel
/*
Ad uzayları (namespace) ve türlerin (types) üyeleri (members) vardır. Bir varlığın üyesine erişmek için genel olarak entity adından sonra bir . konur ardından 
üyenin adı yazılır. Bu şekilde bir varlığın üyesine erişiriz.

Bir türün üyeleri ya türün içerisinde ya da bu türün temel sınıfında tanımlanır. Bir tür temel sınıfından miras aldığında, örnek oluşturucular (instance constructors),
sonlandırıcılar (finalizers) ve statik oluşturucular (static constructors) dışında temel sınıfın tüm üyeleri, türetilen türün üyeleri haline gelir.

Bir temel sınıftaki üyenin erişim bildirgeci (access modifier), üyenin miras alınıp alınmayacağını kontrol edemez. Erişim bildirgecinden bağımsız olarak temel sınıfın 
örnek oluşturucu, statik oluşturucu veya sonlandırıcı hariç geri kalan tüm üyeleri türetilen sınıfın üyeleri haline getirir.

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
//// Person sınıfından miras alındığından ve NameSurname, Age, ShowMyNameAndAge, BirthDate üyelerinin erişim bildirgeçlerinden bağımsız olarak hepsi Customer sınıfına
//// aktarılmıştır. Diğer üç üyenin erişim bildirgeci public olduğu için bunlara Customer sınıfından erişilebilirken BirthDate üyesinin erişim bildirgeci private olduğundan
//// erişilemiyor.
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
Summary: Bir yapının (struct) üyeleri yapı içerisinde tanımlanan üyeler, yapının direk temel sınıfı (direct base class) olan System.ValueType ve dolaylı temel sınıfı olan
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
//            // Yapı içerisindeki bizim tanımladığımız üyeler
//            Console.WriteLine($"Name Surname => {person.NameSurname}");

//            // System.ValueType direk temel sınıfından gelen üyeler
//            // .Equals() metodu üyesi olduğu örnekle (instance) içerisine parametre olarak girilen nesneyi (object) karşılaştırır. Duruma göre true ya da false döndürür.
//            Console.WriteLine($".Equals() => {person.Equals(new Person("Arcan Caner Şenol"))}");
//            // .GetHashCode() metodu üyesi olduğu örneğin şifreli kodunu (hash code) geri döndürür.
//            Console.WriteLine($".GetHashCode() => {person.GetHashCode()}");
//            // .ToString() metodu üyesi olduğu örneğin uzun adını dize (string) tipinde geri döndürür.
//            Console.WriteLine($".ToString() => {person.ToString()}");

//            // object dolaylı temel sınıfından gelen üyeler
//            // .GetType() metodu üyesi olduğu örneğin türünü (type) döndürür.
//            Console.WriteLine($".GetType() => {person.GetType()}");
//        }
//    }
//}
#endregion

#region Sayılabilir Üyeleri (Enumeration Members)
/*
Bir sayılabilirin (enumerable) üyeleri sayılabilir içerisinde tanımlanan sabitlerden (constants), sayılabilirin direk temel sınıfı (direct base class) olan System.Enum, dolaylı temel sınıfı olan
(indirect base class) object ve System.ValueType üyelerinden oluşur.
*/

//namespace Application
//{
//    public enum DaysOfTheWeek
//    {
//        Monday = 1,
//        Tuesday,
//        Wednesday,
//        Thursday,
//        Friday,
//        Saturday,
//        Sunday,
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            // Sayılabilir içerisinde bizim tanımladığımız üyeler
//            Console.WriteLine($"Day Name: {DaysOfTheWeek.Monday}, Day Number: {(int)DaysOfTheWeek.Monday}");
//            Console.WriteLine($"Day Name: {DaysOfTheWeek.Tuesday}, Day Number: {(int)DaysOfTheWeek.Tuesday}");
//            Console.WriteLine($"Day Name: {DaysOfTheWeek.Wednesday}, Day Number: {(int)DaysOfTheWeek.Wednesday}");
//            Console.WriteLine($"Day Name: {DaysOfTheWeek.Thursday}, Day Number: {(int)DaysOfTheWeek.Thursday}");
//            Console.WriteLine($"Day Name: {DaysOfTheWeek.Friday}, Day Number: {(int)DaysOfTheWeek.Friday}");
//            Console.WriteLine($"Day Name: {DaysOfTheWeek.Saturday}, Day Number: {(int)DaysOfTheWeek.Saturday}");
//            Console.WriteLine($"Day Name: {DaysOfTheWeek.Sunday}, Day Number: {(int)DaysOfTheWeek.Sunday}");

//            // System.Enum direk temel sınıfından gelen üyeler
//            // .GetValuesAsUnderlyingType() metodu üyesi olduğu sayılabilirin içindeki üyeleri verilen türde Array olarak geri döndürür.
//            Console.WriteLine($".GetValuesAsUnderlyingType() => {DaysOfTheWeek.GetValuesAsUnderlyingType(typeof(DaysOfTheWeek))}");
//            // Bu metodun alttaki ve üsteki şekillerde iki farklı imzası (method signature) vardır.
//            Console.WriteLine($".GetValuesAsUnderlyingType() => {DaysOfTheWeek.GetValuesAsUnderlyingType<DaysOfTheWeek>()}");
//            // .GetValuesAsUnderlyingType() metodu bizim tanımladığımız sayılabilir yerine onun temel sınıfındaki statik bir metot olduğundan alttaki şekilde de erişilebilir.
//            Console.WriteLine($".GetValuesAsUnderlyingType() => {Enum.GetValuesAsUnderlyingType<DaysOfTheWeek>()}");
//            var values = Enum.GetValuesAsUnderlyingType<DaysOfTheWeek>();
//            Console.WriteLine($"values => {values}");
//            Console.WriteLine($"values.GetValue(0) => {values.GetValue(0)}");
//            Console.WriteLine($"values.GetValue(1) => {values.GetValue(1)}");
//            // !!! .TryParse() metodunun ne işe yaradığını tam olarak anlayamadım. Sonra tekrar dönülecek !!!
//            Console.WriteLine($".TryParse() => {DaysOfTheWeek.TryParse(typeof(DaysOfTheWeek), "Monday", false, out var result)}");
//            Console.WriteLine($".TryParse() => {result.GetType() == typeof(DaysOfTheWeek)}");
//            Console.WriteLine($".TryParse() => {result}");
//        }
//    }
//}
#endregion

#region Sınıf Üyeleri (Class Members)
/*
Bir sınıfın üyeleri, sınıfta tanımlanan üyeler ve temel sınıftan miras alınan üyelerdir -temel sınıfı (base class) olmayan object sınıfı hariç-. Temel sınıftan 
miras alınan üyeler, temel sınıfın sabitlerini (constants), alanlarını (fields), metotlarını (methods), özelliklerini (properties), olaylarını (events), dizin 
oluşturucularını (indexers), operatörlerini (operators) ve türlerini (types) içerir, ancak temel sınıfın örnek oluşturucularını (instance constructors), sonlandırıcılarını
(finalizers) ve statik oluşturucularını (static constructors) içermez. Temel sınıfın tüm üyeleri, türetilen sınıf tarafından erişilebilirliklerine bakılmaksızın miras 
alınır.

object (§8.2.3) ve string (§8.2.5) üyeleri, takma ad (alias) olarak kullanıldıkları sınıf türlerinin üyelerini doğrudan alırlar.

Önceki kısımlarda bu bölümü kapsayan çokça örnek var buraya özel yeni bir örneğe ihtiyaç yok.
*/
#endregion

#region Arayüz Üyeleri (Interface Members)
/*
Bir arayüzün (interface) üyeleri, arayüzde ve arayüzün tüm temel arayüzlerinde tanımlanan üyelerdir.

object sınıfındaki üyeler, kesin olarak herhangi bir arayüzün üyesi değildir (§18.4). object sınıfındaki üyelere herhangi bir arayüz türünde üye arama yoluyla 
ulaşılabilir (§12.5).

Önceki kısımlarda bu bölümü kapsayan çokça örnek var buraya özel yeni bir örneğe ihtiyaç yok.
*/
#endregion

#region Dizi Üyeleri (Array Members)
/*
Bir dizinin üyeleri System.Array sınıfından miras alınan üyelerdir.
*/
#endregion

#endregion