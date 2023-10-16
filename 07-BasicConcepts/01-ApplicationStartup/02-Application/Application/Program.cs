using ClassLibrary;

namespace Application
{
    internal class Program
    {
        #region Tanım
        /*
        C#'taki her uygulamanın (application/executable) bir başlagıç noktası vardır. Bu metoda Main metodu denir.
        Bir metodun başlagıç noktası olabilmesi için taşıması gereken özellikler vardır:
        - Adı Main olmalı
        - static bir metot olmalı
        - generic olmamalı
        - İçinde tanımladığı tür de generic olamaz. Eğer içinde tanımlandığı tür iç içe (nested) bir türse onu kapsayan türlerden hiçbiri generic olamaz
        - Eğer async olarak tanımlanacaksa dönüş türü System.Threading.Tasks.Task ya da System.Threading.Tasks.Task<int> olmak zorunda
        - Sadece void, int, System.Threading.Tasks.Task, ya da System.Threading.Tasks.Task<int> türlerini döndürebilir
        - İmplementasyonu yapılmamış bir partial metot olamaz
        - İçine ya parametre almaz ya da string[] türünde tek bir parametre alır

        Main metodunu aseknron olarak tanımlasak bile C# arka planda bu metodun senkron bir versiyonunu yaratır ve bunu kullanır.
        */
        #endregion

        #region Doğru Kullanım 1
        static void Main(string[] args)
        {
            var person = new Person();
            Console.WriteLine(person.Greeting());
        }
        #endregion

        #region Doğru Kullanım 2
        //static int Main(string[] args)
        //{
        //    var person = new Person();
        //    Console.WriteLine(person.Greeting());
        //    return 0;
        //}
        #endregion

        #region Doğru Kullanım 3
        //static async Task Main(string[] args)
        //{
        //    var person = new Person();
        //    Console.WriteLine(person.Greeting());
        //}
        #endregion

        #region Doğru Kullanım 4
        //static async Task<int> Main(string[] args)
        //{
        //    var person = new Person();
        //    Console.WriteLine(person.Greeting());
        //    await Task.Delay(100);
        //    return 0;
        //}
        #endregion
    }
}