/*
Bu proje türüne ise Application ya da Executable denir.
Bir başlangıç noktası vardır ve çalıştırılabilir.
*/
namespace Application
{
    internal class Program
    {
        #region Tanım
        /*
        C#'ta bir programın application olarak (compiling) derlenebilmesi için içerisinde bulunan en az bir metodun alttaki şartları karşılaması gerekir:
        - Metodun adı Main olmalıdır.
        - static bir metot olmalıdır.
        - generic bir metot olamaz.
        - Eğer metotta belirtilen tip (nested) içiçe bir tipse onu kapsayan tiplerin hiçbiri generic olamaz.
        - Dönüş tipi System.Threading.Tasks.Task ya da System.Threading.Tasks.Task<int> olarak belirtilirse async deyimi bulundurabilir.
        - Dönüş tipleri void, int, System.Threading.Tasks.Task, ya da System.Threading.Tasks.Task<int> olmalıdır.
        */
        #endregion

        #region Doğru Kullanımlar
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        #endregion

        #region Yanlış Kullanımlar
        // --- YANLIŞ KULLANIMLAR ---
        // static yerine public veya başka bir erişim bildigeci verilirse hata alırız.
        //public void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //}
        #endregion
    }
}