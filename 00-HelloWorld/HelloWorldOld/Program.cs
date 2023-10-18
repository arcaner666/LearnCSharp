/*
Eski .NET versiyonlarındaki Program.cs
Ad alanı (namespace) kodlarımızın kapsamını belirlemeye yarıyor.
Böylece ad alanında tanımladığımız değişkenlerimiz, metotlarımız .NET  kütüphaneleriyle veya diğer üçüncü parti yazılımlarla çakışmamış oluyor.
C#'ta her ad alanı, sınıf (class) ve metodun (method) kapsamı {} işaretleriyle belirlenir. Bu ikisi arasında kalan her şey bu kapsama aittir. Buna blok (block) da denir.
*/
namespace HelloWorldOld
{
    /*
    Sınıflar nesne yönelimli programlanın (Object-Oriented Programming) ana öğelerinden biridir. Kodlarımızı sınıflar yardımıyla organize ediyoruz.
    Sınıflar içerisinde özellikler (properties) ve metotlar bulundurabiliyor.
    Buradaki dahili (internal) deyimi ise bir erişim bildirgecidir (access modifier). Bu sınıfa nereden erişilebileceğini belirtiyor.
    */
    internal class Program
    {
        /*
        Main metodu C#'ta kodların çalışmaya başladığı metottur. Programımız ilk buradan çalışmaya başlar.
        Statik (static) deyimi bu programın yeni bir örneği (instance) oluşturulmadan yani new deyimini kullanmadan bu metodun çalıştırılabilmesini sağlar.
        void ise bu metodun çalıştıktan sonra geriye bir değer döndürmediğini gösterir.
        Main metodumuz içerisine string[] yani dize dizisi (string array) olarak argümanlar (arguments) alır. Bu argümanlar programı çalıştırırken derleyiciye (compiler)
        gönderilen komutlardır.
        */
        static void Main(string[] args)
        {
            /*
            Konsol (Console) statik (static) bir sınıftır. İçinde tanımlanmış WriteLine metodu ise konsola çıktı (output) almaya yarar.
            C#'ta bir metodun çalıştırıldığını () işaretlerinden anlarız.
            C#'ta alttaki yapıya ifade (statement) denir.
            Her ifade sonuna ; konur.
            */
            Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your name?");
            // Console.ReadLine metodu kullanıcıdan girdi (input) almamızı sağlar.
            string str = Console.ReadLine();
            // C#'ta + bir operatördür (operator). Altta iki dizeyi (string) birleştirmek için kullanılmıştır.
            Console.WriteLine("Why, hello there " + str);
        }
    }
}

/*
C#'ın yeni versiyonlarıyla beraber dosya kapsamlı alan adı (file-scoped namespace) diye bir özellik daha gelmiştir.
Üstteki alan adı yapısı yerine alttakini de kullanabiliriz. Böylece alttaki alan adının {} işaretlerine ihtiyacı olmaz.
*/

//namespace HelloWorldOld;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Hello, World!");
//    }
//}
