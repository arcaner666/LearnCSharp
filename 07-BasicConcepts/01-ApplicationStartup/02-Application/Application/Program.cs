// Bu proje türüne ise Application ya da Executable denir.
// Bir başlangıç noktası vardır ve çalıştırılabilir.
namespace Application
{
    internal class Program
    {
        // C#'ta bir programın application olarak compile edilebilmesi için içerisinde bulunan en az bir metodun alttaki şartları karşılaması gerekir:
        // - Metodun adı 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}