#region Tanım
/*
Deklarasyonlar ya da tanımlamalar C#'ta bir programı oluşturan elementlerdir. C# programları namespace'ler kullanılarak organize edilir.
namespace tanımlamaları tür (type) tanımlamalarını ve başka namespace tanımlamalarını içerebilirken tür tanımlamaları sınıfları (classes),
struct'ları, interface'leri, enum'ları ve delegate'leri içerebilir. Tür içerisinde hangi üyelerin (members) bulunabileceğine karar verilmesi
bu tanımlamaların formuna göre değişkenlik gösterir. Örneğin sınıf (class) tanımlamaları içerisinde sabitler (constants), alanlar (fields),
metotlar, property'ler, olaylar (events), indexer'lar, operatörler (operators), instance constructor'lar, static constructor'lar, finalizer'lar ve
iç içe türler (nested types) bulunabilir.

Tüm tanımlamalara bir isim verilir ve bu isim nerede yapıldıysa orada geçerlidir. Bu alana tanım uzayı (declaration space) denir.
Aşağıdaki durumlar haricinde aynı tanım uzayında aynı ada sahip iki tanımlama yapmak kodlar derlenirken hata döndürür:

Madde 1) Aynı tanım uzayında aynı ada sahip iki namespace bulunabilir. Bunlar birleştirilerek tek bir tanım uzayındaymış gibi çalışırlar.

Madde 2) Ayrı programlar içerisinde bulunan fakat aynı tanım uzayı içerisinde çağrılan aynı isimde tanımlamalar yapılabilir. Fakat C# hangisini
seçeceğini bilemez ve bize sorar. Sadece birini referans gösterebiliriz.

Madde 3) Aynı tanım uzayında aynı ada sahip fakat imzaları (method signature) farklı birden fazla metot tanımlanabilir.

Madde 4) Aynı tanım uzayında aynı türde fakat farklı sayıda ve türde parametre alan iki tür oluşturulabilir.

Madde 5) Aynı tanım uzayında partial erişim bildirgecine sahip aynı türde, aynı sayıda ve aynı türde tür parametreleri alan iki tür oluşturulabilir. 
Bu ikisi tek bir tanım uzayında birleştirilir.
*/
#endregion

#region Madde 1
/*
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
namespace Application
{
    public class Ages
    {
        public int Age { get; set; } = 16;
    }

    public partial class SameClass<T>
    {
        private T _type;
        private Ages? ages;
        public SameClass(T type)
        {
            _type = type;
            if (typeof(T) == typeof(Ages))
                ages = type as Ages;
        }
        public string Show1()
        {
            return $"Type is {typeof(T)}. And age is {ages.Age}";
        }
    }
    public partial class SameClass<T>
    {
        public string Show2()
        {
            return "There is no type in here.";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var showAges = new SameClass<Ages>(new Ages());
            Console.WriteLine(showAges.Show1());
            Console.WriteLine(showAges.Show2());
        }
    }
}
#endregion