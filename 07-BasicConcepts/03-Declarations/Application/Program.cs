#region Tanımlamalar (Declarations)

#region Tanım
/*
Deklarasyonlar ya da tanımlamalar C#'ta bir programı oluşturan elementlerdir. C# programları namespace'ler kullanılarak organize edilir.
namespace tanımlamaları tür (type) tanımlamalarını ve başka namespace tanımlamalarını içerebilirken tür tanımlamaları sınıfları (classes),
struct'ları, interface'leri, enum'ları ve delegate'leri içerebilir. Tür içerisinde hangi üyelerin (members) bulunabileceğine karar verilmesi
bu tanımlamaların formuna göre değişkenlik gösterir. Örneğin sınıf (class) tanımlamaları içerisinde sabitler (constants), alanlar (fields),
metotlar, property'ler, olaylar (events), indexer'lar, operatörler (operators), instance constructor'lar, static constructor'lar, finalizer'lar ve
iç içe türler (nested types) bulunabilir.
*/

/*
Tüm tanımlamalara bir isim verilir ve bu isim nerede tanımlandıysa kapsamı orasıyla sınırlıdır. Bu alana tanım uzayı (declaration space) denir.
Aşağıdaki durumlar haricinde aynı tanım uzayında aynı ada sahip iki tanımlama yapmak kodlar derlenirken hata döndürür:
*/
#endregion

#region Madde 1
/*
Madde 1) Aynı tanım uzayında aynı ada sahip iki namespace bulunabilir. Bunlar birleştirilerek tek bir tanım uzayındaymış gibi çalışırlar.

Alttaki namespace'deki Program sınıfı Person sınıfına hiçbir şekilde referans içermiyor. Fakat ikisinin namespace'i aynı olduğu için C# bunların
tanım uzaylarını birleştiriyor. Person sınıfının içinde bulunduğu namespace'in adını Application yerine başka bir şey yaparsak Program sınıfındaki
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
Madde 2) Farklı programlar içerisinde bulunan fakat aynı tanım uzayı içerisinde çağrılan aynı isimde tanımlamalar yapılabilir. Fakat C# hangisini 
seçeceğini bilemez ve bize sorar. Sadece birini referans gösterebiliriz.

!!! Burayı açıp çalıştırma sadece incele çünkü ReSharper using Application1; satırını silip ilk namespace'in adını da Application olarak değiştiriyor.
Böylece iki tanım uzayını birleştirerek birini seçmeye zorluyor !!!

İki farklı namespace içerisinde Person adında aynı ada sahip iki sınıf var. Bu sınıfı başka bir namespace içerisinde çağırmak istersek using ile
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
Madde 3) Aynı tanım uzayında aynı ada sahip fakat imzaları (method signature) farklı birden fazla metot tanımlanabilir.

Aşağıdaki {}'lerden önceki static string Greetings() bölümüne metot imzası (method signature) denir.
İki farklı imzaya sahip metot oluşturma işlemine de method overloading denir.
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
Madde 4) Aynı tanım uzayında aynı türde fakat farklı sayıda ve türde parametre alan iki tür oluşturulabilir.

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
Madde 5) Aynı tanım uzayında partial erişim bildirgecine sahip aynı türde, aynı sayıda ve aynı türde tür parametreleri alan iki tür oluşturulabilir.
Bu ikisi tek bir tanım uzayında birleştirilir.
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
Madde 6) Aynı tanım uzayında aynı adda bir namespace ve bir tür bulunabilir. Yalnızca türün bir tür parametresi alması gerekir.

Burada aynı tanım uzayında hem Application adında bir namespace hem de Application<T> adında bir sınıf tanımlanabilmiştir.
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

#endregion

#region Tanım Uzayı Türleri (Declaration Space Types)

#region Tanım
/*
Farklı tanım uzayı türleri vardır:
*/
#endregion

#region Tür 1
/*
Tür 1) Programın tüm derleme birimlerinde (compilation units of program) onu kapsayan herhangi bir namespace bulunmayan tüm üyeler 
küresel tanım uzayında (global declaration space) birleştirilir.

Burada A ve B sınıfları Application namespace'inde tanımlı olmamalarına rağmen Application içerisinden çağrılabilmiştir.
Bunun sebebi A, B ve Application'ın aynı küresel tanım uzayında olmasıdır.
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
Tür 2) Programın tüm derleme birimlerinde (compilation units of program) bir namespace içerisindeki aynı uzun namespace adına (fully qualified namespace) sahip
iki üye (member) tek bir tanım uzayında birleştirilir.

Burada A ve B sınıfları Namespace1 namespace'inde tanımlanmışlardır. Application'dan bu sınıflara erişmeye çalışınca ikisine de yalnızca tek bir using Namespace1;
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
Tür 3) Her bir derleme biriminin (compilation unit) ve tanımın (declaration_body) kendine özel bir takma ad tanım uzayı (alias declaration space) vardır.
Dışarıdan referans gösterilen her bir dış takma ad yönergesi (extern alias directive) ve içeride oluşturulan takma ad yönergeleri (alias directive) buradaki
takma ad tanım uzayına yeni bir üye (member) olarak eklenir.

Burada 
*/

extern alias Namespace1;
extern alias Y;

class Y { } // Ok

namespace Application
{
    public class A
    {
        public string NameSurname { get; set; } = "Arcan Caner Şenol";
    }
}

namespace Application
{
    public class B
    {
        public int Age { get; set; } = 28;
    }
}

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            Console.WriteLine($"My name is {a.NameSurname} and I am {b.Age} years old.");
        }
    }
}
#endregion

#endregion