#region Tanımlamalar (Declarations)
/*
Tanımlamalar (declarations) C#'ta bir programı oluşturan elementlerdir. C# programları ad alanları (namespace) kullanılarak organize edilir.
Ad alanı tanımlamaları tür (type) tanımlamalarını ve başka ad alanı tanımlamalarını içerebilirken tür tanımlamaları sınıfları (classes),
yapıları (structs), arayüzleri (interface), sayılabilirleri (enumerable) ve delegeleri (delegate) içerebilir. Tür içerisinde hangi üyelerin (members)
bulunabileceğine karar verilmesi bu tanımlamaların formuna göre değişkenlik gösterir. Örneğin sınıf tanımlamaları içerisinde sabitler (constants), alanlar (fields),
metotlar (methods), özellikler (properties), olaylar (events), dizinleyici (indexers), operatörler (operators), örnek oluşturucular (instance constructors), 
statik oluşturucular (static constructors), sonlandırıcılar (finalizer) ve iç içe türler (nested types) bulunabilir.
*/

/*
Tüm tanımlamalara bir isim verilir ve bu isim nerede tanımlandıysa kapsamı orasıyla sınırlıdır. Bu alana tanım uzayı (declaration space) denir.
Aşağıdaki durumlar haricinde aynı tanım uzayında aynı ada sahip iki tanımlama yapmak kodlar derlenirken hata döndürür:
*/

#region Madde 1
/*
Aynı tanım uzayında aynı ada sahip iki ad alanı (namespace) bulunabilir. Bunlar birleştirilerek tek bir tanım uzayındaymış gibi çalışırlar.

Alttaki ad alanındaki Program sınıfı Person sınıfına hiçbir şekilde referans göstermiyor. Fakat ikisinin ad alanı aynı olduğu için C# bunların
tanım uzaylarını birleştiriyor. Person sınıfının içinde bulunduğu ad alanının adını Application yerine başka bir şey yaparsak Program sınıfındaki
hata mesajını görebiliriz.
*/

//namespace Application
//{
//    public class Person
//    {
//        public string name = "Arcan Caner";
//        public int age = 28;

//        public string Greeting()
//        {
//            return $"{name} is {age} year old.";
//        }
//    }
//}

//namespace Application
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var person = new Person();
//            Console.WriteLine(person.Greeting());
//        }
//    }
//}
#endregion

#region Madde 2
/*
Farklı programlar içerisinde bulunan fakat aynı tanım uzayı içerisinde çağrılan aynı isimde tanımlamalar yapılabilir. Fakat C# hangisini 
seçeceğini bilemez ve bize sorar. Sadece birini referans gösterebiliriz.

!!! Burayı açıp çalıştırma sadece incele çünkü ReSharper using Application1; satırını silip ilk ad alanının adını da Application olarak değiştiriyor.
Böylece iki tanım uzayını birleştirerek birini seçmeye zorluyor !!!

İki farklı ad alanı içerisinde Person adında aynı ada sahip iki sınıf var. Bu sınıfı başka bir ad alanı içerisinde çağırmak istersek using ile
sadece birini seçmek zorunda kalıyoruz.
*/
//using Application1;

//namespace Application1
//{
//    public class Person
//    {
//        public int age = 28;
//        public string name = "Arcan Caner";

//        public string Greeting()
//        {
//            return $"{name} is {age} year old.";
//        }
//    }
//}

//namespace Application2
//{
//    public class Person
//    {
//        public int age = 20;
//        public string name = "Yaşar Taner";

//        public string Greeting()
//        {
//            return $"{name} is {age} year old.";
//        }
//    }
//}

//namespace Application
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var person = new Person();
//            Console.WriteLine(person.Greeting());
//        }
//    }
//}
#endregion

#region Madde 3
/*
Aynı tanım uzayında aynı ada sahip fakat imzaları (method signature) farklı birden fazla metot tanımlanabilir.

Aşağıdaki {} işaretlerinden önceki static string Greetings() bölümüne metot imzası (method signature) denir.
İki farklı imzaya sahip metot oluşturma işlemine de metodu aşırı yükleme (method overloading) denir.
*/

//namespace Application
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(Greetings());
//            Console.WriteLine(Greetings("Yaşar Taner Şenol"));
//        }

//        static string Greetings()
//        {
//            return "My name is Arcan Caner Şenol.";
//        }

//        static string Greetings(string name)
//        {
//            return $"My name is {name}.";
//        }
//    }
//}
#endregion

#region Madde 4
/*
Aynı tanım uzayında aynı ada sahip fakat farklı sayıda tür parametresi (type parameters) alan iki ya da daha fazla sayıda tür oluşturulabilir.

Burada iki sınıf da SameClass olarak hata almadan adlandırılmıştır. Sadece bir sınıf içerisine bir tür parametresi alırken diğeri almaz.
*/

//namespace Application
//{
//    public class Ages
//    {
//        public int Age { get; set; } = 16;
//    }
//    public class Names
//    {
//        public string Name { get; set; } = "Arcan Caner";
//    }

//    public class SameClass<T>
//    {
//        public string Show()
//        {
//            return $"Type is {typeof(T)}.";
//        }
//    }
//    public class SameClass
//    {
//        public string Show()
//        {
//            return "There is no type in here.";
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var showNames = new SameClass<Names>();
//            Console.WriteLine(showNames.Show());

//            var showAges = new SameClass<Ages>();
//            Console.WriteLine(showAges.Show());

//            var showNothing = new SameClass();
//            Console.WriteLine(showNothing.Show());
//        }
//    }
//}
#endregion

#region Madde 5
/*
Aynı tanım uzayında kısmi (partial) erişim bildirgecine (access modifier) sahip aynı türde, içine aldığı tür parametreleri aynı sayıda 
ve türde olan iki tür oluşturulabilir. Bu ikisi tek bir tanım uzayında birleştirilir.
*/

//namespace Application
//{
//    public class Ages
//    {
//        public int Age { get; set; } = 16;
//    }

//    public partial class SameClass<T>
//    {
//        private T _type;
//        private Ages? ages;
//        public SameClass(T type)
//        {
//            _type = type;
//            if (typeof(T) == typeof(Ages))
//                ages = type as Ages;
//        }
//        public string Show1()
//        {
//            return $"Type is {typeof(T)}. And age is {ages.Age}";
//        }
//    }
//    public partial class SameClass<T>
//    {
//        public string Show2()
//        {
//            return "There is no type in here.";
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var showAges = new SameClass<Ages>(new Ages());
//            Console.WriteLine(showAges.Show1());
//            Console.WriteLine(showAges.Show2());
//        }
//    }
//}
#endregion

#region Madde 6
/*
Aynı tanım uzayında aynı ada sahip bir ad alanı (namespace) ve bir tür bulunabilir. Yalnızca türün en az bir tür parametresi alması gerekir.

Burada aynı tanım uzayında hem Application adında bir ad alanı hem de Application<T> adında bir sınıf tanımlanabilmiştir.
*/
//public class Ages
//{
//    public int Age { get; set; } = 16;
//}

//public class Application<T>
//{
//    public string Show1()
//    {
//        return $"The type is {typeof(T)}.";
//    }
//}

//namespace Application
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var showAges = new Application<Ages>();
//            Console.WriteLine(showAges.Show1());
//        }
//    }
//}
#endregion

/*
Farklı tanım uzayı türleri vardır:
*/

#region Tür 1
/*
Programın tüm derleme birimlerinde (compilation units of program) onu kapsayan herhangi bir ad alanı (namespace) bulunmayan tüm üyeler (members)
küresel tanım uzayında (global declaration space) birleştirilir.

Burada A ve B sınıfları Application ad alanında tanımlı olmamalarına rağmen Application içerisinden çağrılabilmiştir.
Bunun sebebi A, B ve sınıflarının aynı küresel tanım uzayında olmasıdır.
*/

//public class A
//{
//    public string NameSurname { get; set; } = "Arcan Caner Şenol";
//}

//public class B
//{
//    public int Age { get; set; } = 28;
//}

//namespace Application
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = new A();
//            var b = new B();
//            Console.WriteLine($"My name is {a.NameSurname} and I am {b.Age} years old.");
//        }
//    }
//}
#endregion

#region Tür 2
/*
Programın tüm derleme birimlerinde (compilation units of program) bir ad alanı (namespace) içerisindeki aynı uzun ad alanı adına (fully qualified namespace) sahip
iki üye (member) tek bir tanım uzayında birleştirilir.

Burada A ve B sınıfları Namespace1 ad alanında tanımlanmışlardır. Application içerisinden bu sınıflara erişmeye çalışınca ikisine de yalnızca tek bir using Namespace1;
ile ulaşabildik. Çünkü aynı tanım uzayındalar.
*/

//using Namespace1;

//namespace Namespace1
//{
//    public class A
//    {
//        public string NameSurname { get; set; } = "Arcan Caner Şenol";
//    }
//}

//namespace Namespace1
//{
//    public class B
//    {
//        public int Age { get; set; } = 28;
//    }
//}

//namespace Application
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var a = new A();
//            var b = new B();
//            Console.WriteLine($"My name is {a.NameSurname} and I am {b.Age} years old.");
//        }
//    }
//}
#endregion

#region Tür 3
/*
Her bir derleme biriminin (compilation unit) ve tanımın (declaration_body) kendine özel bir takma ad tanım uzayı (alias declaration space) vardır.
Dışarıdan referans gösterilen her bir dış takma ad yönergesi (extern alias directive) ve içeride oluşturulan takma ad yönergeleri (alias directive) buradaki
takma ad tanım uzayına yeni bir üye (member) olarak eklenir.

Burada N3 ad alanı içerisinde using A = N1.N2.A; şeklinde bir takma ad yönergesi kullanılmış. Artık A kelimesi N3 ad alanı içerisinde N1.N2.A'ya karşılık geliyor.
Aynı şekilde A adında başka bir takma ad yönergesi kullanılamaz.
*/

//namespace N1.N2
//{
//    public class A
//    {
//        public string NameSurname { get; set; } = "Arcan Caner Şenol";
//    }
//}

//namespace N3
//{
//    using A = N1.N2.A;

//    public class B : A
//    {
//        public int Age { get; set; } = 28;
//    }
//}

//namespace Application
//{
//    using N3;
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var b = new B();
//            Console.WriteLine($"My name is {b.NameSurname} and I am {b.Age} years old.");
//        }
//    }
//}
#endregion

#region Tür 4
/*
Kısmi olmayan her bir sınıf (non-partial class), yapı (struct) ve arayüz (interface) yeni bir tanım uzayı (declaration space) oluşturur. Her kısmi sınıf, yapı
ve arayüz aynı program içerisinde kullanıldıkları yerler arasında paylaşılan tanım uzayına da katkıda bulunur. Sınıf, yapı, arayüz üye tanımları ve tür tanımlarıyla 
yeni isimler bu tanım uzayına eklenir. Aşırı yüklenmiş örnek oluşturucu (overloaded instance constructors) tanımları ve statik oluşturucu (static constructor) tanımları 
hariç olmak üzere bir sınıf ya da yapı kendisiyle aynı adı taşıyan bir üyeye (member) sahip olamaz. Bir sınıf, yapı ya da arayüz aşırı yüklenmiş metotların (overloaded methods)
ve dizinleyicilerin (indexers) tanımlamasına izin verir. Ayrıca bir sınıf ya da yapı aşırı yüklenmiş örnek oluşturucuların ve operatörlerin tanımlanmasına da izin verir.
Temel sınıfların (base classes) bir sınıfın tanım uzayına katkıda bulunmadığını ve temel arayüzlerin (base interfaces) bir arayüzün tanım uzayına katkıda bulunmadığını unutmamalıyız.
Böylece, türetilmiş bir sınıf veya arayüzün (derived class or interface), miras alınan üyeyle (inherited member) aynı adı taşıyan bir üyeyi tanımlanmasına izin verilir. 
Böyle bir durumda aynı adda oluşturulan yeni üye miras alınan sınıf ya da arayüzde bulunan üyeyi gizler (hiding). Derleyici bu durumu bize bildirir.
*/

//namespace Application
//{
//    public class A
//    {
//        // Sınıf ile özellik (property) aynı ada sahip olamaz. Hata veriyor.
//        //private string A { get; set; } = "Arcan Caner Şenol";

//        private string Str { get; set; } = "Arcan Caner Şenol";

//        // Örnek oluşturucu ile sınıf aynı isimde olabilir.
//        public A()
//        {
//        }

//        // Oluşturucular aşırı yüklenebilir. Parametrelerinin farklı olması koşuluyla aynı isimde iki oluşturucu olabilir.
//        public A(string str)
//        {
//            Str = str;
//        }

//        public int Sum(int x, int y)
//        {
//            return x + y;
//        }
//        // Aynı sınıf içerisinde imzası farklı fakat aynı adda iki metot bulunabilir.
//        public int Sum(int x, int y, int z)
//        {

//            return x + y + z;
//        }
//    }
//    public struct B
//    {
//        // Yapı ile özellik aynı ada sahip olamaz. Hata veriyor.
//        //private string B { get; set; } = "Arcan Caner Şenol";

//        private string Str { get; set; } = "Arcan Caner Şenol";

//        // Örnek oluşturucu ile yapı aynı isimde olabilir.
//        public B(string str)
//        {
//            Str = str;
//        }
//    }
//    interface IC
//    {
//        // Arayüzlerde oluşturucu tanımlanamaz çünkü bir arayüzden bir nesne örneği elde edilemez.

//        public int Sum(int x, int y);
//        // Aynı arayüz içerisinde imzası farklı fakat aynı adda iki metot bulunabilir.
//        public int Sum(int x, int y, int z);
//    }
//    public static class D
//    {
//        // Sınıf ile özellik aynı ada sahip olamaz. Hata veriyor.
//        //public static string D { get; set; } = "Arcan Caner Şenol";

//        // Statik sınıflarda oluşturucu bulunmaz çünkü küresel tanım uzayında bir statik türden yalnızca bir örnek bulunabilir ve bu örnek paylaşılır.
//        // Ancak statik sınıflarda statik oluşturucu tanımlanabilir. Bir statik oluşturucu yalnızca statik sınıf hafızada ilk kez örneği oluşturulduğunda çağrılır.
//        static D()
//        {

//        }

//    }
//    public class E
//    {
//        public string NameSurname { get; set; } = "Arcan Caner Şenol";
//    }
//    public class F : E
//    {
//        // F sınıfı E'den miras alıyor fakat F'in içindeki NameSurname özelliği E'dekini gizler.
//        public string NameSurname { get; set; } = "Yaşar Taner Şenol";
//    }
//}
#endregion

#region Tür 5
/*
Her delege (delegate) tanımı yeni bir tanım uzayı oluşturur. Adlar bu tanım uzayına parametreler (fixed parameters and parameter arrays) ve 
tür parametreleri (type parameters) aracılığıyla eklenir.
*/

//namespace Application
//{
//    public delegate int Delegate1(int x, int y);
//    public delegate int Delegate2(int x, int y, int z);
//    public class Math
//    {
//        public static int Sum(int x, int y)
//        {
//            return x + y;
//        }

//        public static int Multiply(int x, int y, int z)
//        {
//            return x * y * z;
//        }
//    }

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Delegate1 delegate1 = Math.Sum;
//            Delegate2 delegate2 = Math.Multiply;
//            Console.WriteLine(delegate1(2, 3));
//            Console.WriteLine(delegate2(3, 3, 3));
//        }
//    }
//}
#endregion

#region Tür 6
/*
Her sayılabilir (enumerable) yeni bir tanım uzayı oluşturur. Tanım uzayına eklenen isimler sayılabilir içerisindeki tanımlamalar ile gelir.

Burada aynı iki farklı ada sahip iki tane sayılabilir tanımlanmıştır. Fakat içlerinde aynı isimde üyeler bulundururlar. Her biri kendi tanım uzayını
oluşturduğu için çakışma olmaz.
*/

//namespace Application
//{
//    public enum ActivationStatus
//    {
//        Passive = 0,
//        Active = 1,
//    }
//    public enum EmailApprovalStatus
//    {
//        Passive = 0,
//        Active = 1,
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine(ActivationStatus.Active);
//            Console.WriteLine(EmailApprovalStatus.Active);
//        }
//    }
//}
#endregion

#region Tür 7
/*
Her metot (method), özellik (property), özellik erişim bildirgeci (property accessor), dizinleyici (indexer), dizinleyici erişim bildirgeci (indexer accessor), operatör (operator),
örnek oluşturucu (instance constructor), anonim fonksiyon (anonymous function) ve yerel fonksiyon (local function) yeni bir yerel değişken tanım uzayı 
(local variable declaration space) oluşturur. Adlar bu tanım uzayına parametreler (fixed parameters and parameter arrays) ve tür parametreleri (type parameters) aracılığıyla eklenir.
Bir özellik (property) veya dizine (indexer) eklenen set erişim bildirgeci (set accessor) value adında bir parametre ekler.
*/

//namespace Application
//{
//    public class Math
//    {
//        private int _number1;
//        public Math(int number1)
//        {
//            _number1 = number1;
//        }
//        public int number2 = 10;
//        public int Sum(int x, int y)
//        {
//            return x + y;
//        }

//    }
//    internal class Program
//    {
//        private delegate int Delegate1(int x, int y);
//        static void Main(string[] args)
//        {
//            var math = new Math(5);
//            Delegate1 delegate1 = math.Sum;

//            // _number1 değişkeni private olarak tanımlı olduğundan sadece Math sınıfı içerisinden erişilebilir.
//            //Console.WriteLine($"private int _number1: {math._number1}");

//            Console.WriteLine($"public int number2: {math.number2}");
//            Console.WriteLine($"public int Sum(int x, int y): {math.Sum(2, 5)}");
//            Console.WriteLine($"private delegate int Delegate1(int x, int y): {delegate1(2, 5)}");
//        }
//    }
//}
#endregion

#region Tür 8

#region Tanım
/*
Yeni üye (member), anonim fonksiyon (anonymous function) ve yerel metot (local method) tanımlamalarında yeni yerel değişken tanım uzayları 
(local variable declaration spaces) oluşabilir. Yerel değişken tanım uzayları iç içe geçmiş olabilir, ancak kapsayan yerel değişken tanım uzayında
tanımlanan üyeler ile kapsanan yerel değişken tanım uzayında aynı ada sahip üyeler bulunamaz. Bu nedenle, iç içe geçmiş bir tanım uzaylarında, 
aynı adda iki parametre (parameter), tür parametresi (type parameter), yerel değişken (local variable), yerel metot (local method) veya sabit (constant)
tanımlanamaz. Her iki tanım uzayı da diğerini kapsamadığı sürece, iki tanım uzayının aynı ada sahip üyeler içermesi mümkündür.
*/

//namespace Application
//{
//    public class MathOperations
//    {
//        public int y = 10;
//        public int AddTen(int x)
//        {
//            // Kapsayan tanım uzaylarında aynı adda iki metot bulunamaz.
//            public int AddTen(int x)
//            {
//                private int y = 10; 
//                return x + y;
//            }

//            // MathOperations sınıfında zaten y adında bir değişken tanımlanmış bu sebeple hata veriyor.
//            private int y = 10;
//            return x + y;
//        }
//    }
//}
#endregion

#region Yerel Değişken Tanım Uzayı Oluşturma Kuralları
/*
Yerel değişken tanım uzayları aşağıdaki kurallara göre oluşturulur:
*/

#region Kural 1
/*
Her alandaki (field) ve özellikteki (property) değişken başlatıcı (variable initializer) kendi yerel değişken tanım uzayını oluşturur ve burası
diğer yerel değişken tanım uzayları içerisinde yer alamaz.
*/

//namespace Application
//{
//    public class Class1
//    {
//        private string _name;
//        public string Name
//        {
//            get
//            {
//                var initialString = "Test";
//                return _name is null ? initialString : _name;
//            }
//            set => _name = value;
//        }
//        // Burada Name ve Surname alanlarından sonra gelen {} kısmına değişken başlatıcı (variable initializer) denir ve alttaki ve üstteki değişken başlatıcıların kendilerine özel 
//        // yerel değişken tanım uzayları vardır. Bu sayede ikisinin içinde de aynı isimde bir değişken çakışmadan tanımlanabilir.
//        private string _surname;
//        public string Surname
//        {
//            get
//            {
//                var initialString = "Test";
//                return _surname is null ? initialString : _surname;
//            }
//            set => _surname = value;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var class1 = new Class1();
//            Console.WriteLine(class1.Name);
//            Console.WriteLine(class1.Surname);
//            class1.Name = "Arcan Caner";
//            class1.Surname = "Şenol";
//            Console.WriteLine(class1.Name);
//            Console.WriteLine(class1.Surname);
//        }
//    }
//}
#endregion

#region Kural 2
/*
Anonim ve yerel metotların (anonymous and local methods) içi, bu metotların içinde bulunduğu yerel değişken tanım uzayına dahil 
olan yeni bir yerel değişken tanım uzayı oluşturur.
*/

//namespace Application
//{
//    public class Class1
//    {
//        public int x = 10;
//        public int SumTwoNumbers()
//        {
//            int x = 7;
//            int y = 5;
//            return x + y;
//        }
//        // Aynı x ve y değişkenleri farklı iki metodun içerisinde tanımlanabilmiştir. Fakat onları kapsayan yerel değişken tanım uzayında
//        // aynı isimde değişken olamaz. Burada SumTwoNumbers metodu içerisindeki x değişkeni Class1'in üzerine yazar.
//        public int SumAnotherTwoNumbers()
//        {
//            int x = 2;
//            int y = 3;
//            return x + y;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var class1 = new Class1();
//            Console.WriteLine(class1.SumTwoNumbers());
//            Console.WriteLine(class1.SumAnotherTwoNumbers());
//        }
//    }
//}
#endregion

#region Kural 3
/*
Her oluşturucu başlatıcısı (constructor initializer) örnek oluşturucu tanımının (instance constructor declaration) içerisinde yeni bir yerel değişken tanım uzayı 
(local variable declaration space) oluşturur. Oluşturucunun gövdesinde yeni oluşturulan bu uzay aynı zamanda içinde bulunduğu yerel değişken tanım uzayına dahildir.
*/

//namespace Application
//{
//    public class Class1
//    {
//        private int x = 2;
//        public int result = 0;
//        public Class1()
//        {
//            // Burada y oluşturucu başlatıcısının içerisinde tanımlanmıştır ve sadece burada tanımlıdır. Class1 sınıfının yerel değişken tanım alanı burayı kapsadığı için x ve result
//            // değişkenleri burada tanımlı olmamalarına rağmen bu değişkenlere erişilmiştir.
//            int y = 5;
//            result = x + y;
//        }
//    }
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var class1 = new Class1();
//            Console.WriteLine(class1);
//        }
//    }
//}
#endregion

#region Kural 4
/*
Her blok (block), switch bloğu, catch bloğu, döngü tanımlamaları (iteration declaration), using tanımlamaları tanımlandıkları alan tarafından kapsanan yeni bir yerel değişken 
tanım uzayı oluştururlar.
*/

//namespace Application
//{
//    public class Class1
//    {
//        public string SomeMethod()
//        {
//            var innerVariable = "inner";
//            return innerVariable;
//        }
//        // innerVariable değişkeni SomeMethod metodu içerisindeki yerel değişken tanımlama uzayında olduğundan buradan ulaşılamaz.
//        innerVariable = null;

//        public int number = 1;
//        public string GetDayName(int number)
//        {
//            var dayName = "";
//            switch (number)
//            {
//                case 1:
//                    var innerVariable = "Monday";
//                    dayName = innerVariable;
//                    break;
//                case 2:
//                    dayName = "Tuesday";
//                    break;
//            }
//            // innerVariable değişkeni switch içerisindeki yerel değişken tanımlama uzayında olduğundan buradan ulaşılamaz.
//            innerVariable = "Saturday";
//            return dayName;
//        }
//        public void TrySomething()
//        {
//            var errorMessage = "Error !!!";
//            try
//            {
//                var newMessage = "New Error !!!";
//                throw new Exception(errorMessage);
//            }
//            catch (Exception e)
//            {
//                // newMessage değişkeni try içerisindeki yerel değişken tanımlama uzayında olduğundan buradan ulaşılamaz.
//                newMessage = "Error 2 !!!";
//                throw;
//            }
//            // newMessage değişkeni try içerisindeki yerel değişken tanımlama uzayında olduğundan buradan ulaşılamaz.
//            newMessage = "Error 2 !!!";
//        }

//        public void RandomLoop()
//        {
//            for (int i = 0; i < 5; i++)
//            {
//                var innerVariable = i;
//            }
//            // innerVariable değişkeni for döngüsü içerisindeki yerel değişken tanımlama uzayında olduğundan buradan ulaşılamaz.
//            innerVariable = 10;
//        }
//    }
//}
#endregion

#region Kural 5
/*
Doğrudan bir ifade listesinin (statement list) bir parçası olmayan her gömülü ifade (embedded statement), iç içe yeni bir yerel değişken tanım uzayı oluşturur.
*/

//namespace Application
//{
//    public class Class1
//    {
//        public class Program
//        {
//            //static void SomeMethod1(bool b)
//            //{
//            //    if (b)
//            //        int i = 44; // if bloğunun içerisinde bir gömülü ifade bulunmalıdır. Fakat burada normal bir ifade tanımlanmıştır. Hata döndürür.
//            //}
//            static void SomeMethod2(bool b)
//            {
//                if (b)
//                {
//                    int i = 44; // Burada ise bir hata olmaz.
//                }
//            }
//            static void SomeMethod3(bool b)
//            {
//                int i = 44;
//                if (b)
//                    i = 7;
//            }
//            static void Main(string[] args)
//            {
//                //SomeMethod1(true);
//                SomeMethod2(true);
//                SomeMethod3(true);
//            }
//        }
//    }
//}
#endregion

#region Kural 6
/*
Her switch kendi yerel değişken tanım uzayını oluşturur. Fakat switch içerisindeki her bir case içinde tanımlanan değişkenler ortak bir yerel değişken tanım 
uzayında birleşir.
*/

//namespace Application
//{
//    public class Class1
//    {
//        public string GetDayName(int number)
//        {
//            var dayName = "";
//            switch (number)
//            {
//                case 1:
//                    var innerVariable = "inner";
//                    dayName = "Monday";
//                    break;
//                case 2:
//                    // Her bir switch bölümü yeni bir yerel değişken tanımlama uzayı oluşturmaz. Tüm bölümleri oluşturduğu uzay birleştirilir.
//                    var innerVariable = "inner";  
//                    dayName = "Tuesday";
//                    break;
//            }
//            // innerVariable değişkeni switch içerisindeki yerel değişken tanımlama uzayında olduğundan buradan ulaşılamaz.
//            innerVariable = "Saturday";
//            return dayName;
//        }
//    }
//}
#endregion

#region Kural 7
/*
Sorgu ifadelerinin (query expressions) (§12.20.3) çevirisi bir ya da daha fazla sayıda lambda ifadeye çevrilebilir. Anonim metotlar (anonymous methods) 
üstte de bahsedildiği gibi kendi yerel değişken tanım uzaylarını yaratırlar.
*/

//namespace Application
//{
//    public class Class1
//    {
//        public bool FindWordContainsAChar(char character)
//        {
//            string text = "Arcan Caner Şenol is 28 years old.";
//            char searchedChar = text.SingleOrDefault(w => w == character);
//            // w değişkeni anonim metot içerisindeki yerel değişken tanımlama uzayında olduğundan buradan ulaşılamaz.
//            w = 'd';
//            return searchedChar == null ? true : false;
//        }
//    }
//}
#endregion

#endregion

#endregion

#region Tür 9
/*
Tür 9) Her blok ya da switch bloğu isimler için yeni bir tanım uzayı oluşturur. Bu tanım uzayları içinde bulunan tüm tanım uzaylarını kapsar. Bu sebeple iç içe iki tanım
uzayında kapsayan blok içerisinde ve içindeki blokta aynı isimde iki üye tanımlanamaz.
*/

//class A
//{
//    void F()
//    {
//        int i = 0;
//        if (true)
//        {
//            // i zaten bir üst tanım uzayında tanımlanmış hata verir.
//            int i = 1;
//        }
//    }
//    void G()
//    {
//        if (true)
//        {
//            int i = 0;
//        }
//        // i zaten bir iç tanım uzayında tanımlanmış hata verir.
//        int i = 1;
//    }
//    void H()
//    {
//        if (true)
//        {
//            int i = 0;
//        }
//        if (true)
//        {
//            // Burada bir sorun olmaz çünkü iki bloğun kendi yerel değişken tanım uzayı farklıdır.
//            int i = 1;
//        }
//    }
//    void I()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            H();
//        }
//        // Her döngü kendi yerel değişken tanım uzayını oluşturur.
//        for (int i = 0; i < 10; i++)
//        {
//            H();
//        }
//    }
//    void J()
//    {
//        for (int i = 0; i < 10; i++)
//        {
//            H();
//            // Her döngü içinde bulunduğu tanım uzayına dahil olur.
//            // Burada i dış tanım uzayında zaten tanımlıdır.
//            for (int i = 0; i < 10; i++)
//            {
//                H();
//            }
//        }
//    }
//}
#endregion

/*
Tanımların hangi sırayla yapıldığının genel olarak bir önemi yoktur. Özellikle yazım sıralaması isim uzayları (namespaces), sabitler (constants), metotlar (methods),
özellikler (properties), olaylar (events), dizinler (indexers), operatörler (operators), örnek oluşturucular (instance constructors), sonlandırıcılar (finalizers),
statik oluşturucular (static constructors), ve türler (types) için önemli değildir.

Tanım sıralaması sadece aşağıdaki durumlarda önemlidir:
*/

#region Durum 1
/*
Alan tanımlamalarının (field declaration) sırası eğer varsa başlatıcılarının (initializer) çalışma sırasını belirler.
*/
#endregion

#region Durum 2
/*
Yerel değişkenler çağrılmadan önce tanımlanmalıdır.
*/
#endregion

#region Durum 3
/*
Sayılabilirler (enumerable) sabit değerlerle index belirtmeden tanımlanırken tanım sırası index numarasını belirler.
*/

enum Color1
{
    Red,
    Green,
    Blue
}
enum Color2
{
    Blue,
    Red,
    Green
}
class Test
{
    static void Main()
    {
        Console.WriteLine("--- Order 1 ---");
        Console.WriteLine($"{Color1.Red} {(int)Color1.Red}");
        Console.WriteLine($"{Color1.Green} {(int)Color1.Green}");
        Console.WriteLine($"{Color1.Blue} {(int)Color1.Blue}");
        Console.WriteLine("--- Order 2 ---");
        Console.WriteLine($"{Color2.Red} {(int)Color2.Red}");
        Console.WriteLine($"{Color2.Green} {(int)Color2.Green}");
        Console.WriteLine($"{Color2.Blue} {(int)Color2.Blue}");
    }
}
#endregion
#endregion