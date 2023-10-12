// Eski .NET versiyonlarındaki Program.cs
// namespace kodlarımızın kapsamını belirlemeye yarıyor.
// Böylece namespace'de tanımladığımız değişkenlerimiz, metotlarımız .NET'in kendi kütüphaneleriyle veya diğer üçüncü parti yazılımlarla çakışmamış oluyor.
// C#'ta her namespace, class ve fonksiyonun kapsamı {} işaretleriyle belirlenir. Bu ikisi arasında kalan her şey bu kapsama aittir. Buna blok da denir.
namespace HelloWorldOld
{
    // class'lar nesne yönelimli programlanın ana yapıtaşlarından biridir. Kodlarımızı classlar yardımıyla organize ediyoruz.
    // class'lar içerisinde property'ler ve metotlar bulundurabiliyor.
    // Buradaki internal deyimi ise bir erişim bildirgecidir. Bu sınıfa nereden erişilebileceğini belirtiyor.
    internal class Program
    {
        // Main fonksiyonu C#'ta kodların çalışmaya başladığı fonksiyondur. Programımız ilk buradan çalışmaya başlar.
        // static deyimi bu programın yeni bir instance'ı oluşturulmadan yani new deyimini kullanmadan bu fonksiyonun çalıştırılabilmesini sağlar.
        // void ise bu fonsiyonun çalıştıktan sonra geriye bir değer döndürmediğini gösterir.
        // Main fonksiyonumuz içerisine string[] yani string dizisi olarak argümanlar alır. Bu argümanlar programı çalıştırırken compiler'a gönderilen komutlardır.
        static void Main(string[] args)
        {
            // Console static bir class'tır. İçindeki WriteLine fonksiyonu ise konsola çıktı almaya yarar.
            // C#'ta bir fonksiyonun çalıştırıldığını () işaretlerinden anlarız.
            // C#'ta alttaki yapıya statement denir.
            // Her statement'tın sonuna ; konur.
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your name?");
            // Console.ReadLine fonskiyonu kullanıcıdan girdi almamızı sağlar.
            string str = Console.ReadLine();
            // C#'ta + bir operatördür. Altta iki string'i birleştirmek için kullanılmıştır.
            Console.WriteLine("Why, hello there " + str);
        }
    }
}

// C#'ın yeni versiyonlarıyla beraber file-scoped namespace diye bir özellik daha gelmiştir.
// Üstteki namespace yapısı yerine alttakini de kullanabiliriz. Böylece alttaki namespace'in {} işaretlerine ihtiyacı olmaz.
//namespace HelloWorldOld;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}
