namespace Application
{
    internal class Program
    {
        #region Tanım
        /*
        Genelde Main metodundan void veya 0 (int) dönmesi programın başarılı bir şekilde çalıştığına işaret eder.

        Eğer içeriden bir istisna (exception) fırlatılırsa program bunu gösterir ve hata aldığımızı farkederiz.

        int döndürdüğümüz durumlarda 0 dışındaki dönen değerlere özel anlamlar yükleyerek hata türü oluşturabiliriz.
        */
        #endregion

        #region Başarılı Bitiş 1
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //}
        #endregion

        #region Başarılı Bitiş 2
        //static int Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    return 0;
        //}
        #endregion

        #region Hatalı Bitiş 1
        //static int Main(string[] args)
        //{
        //    Console.WriteLine("Hello, World!");
        //    return 1;
        //}
        #endregion

        #region Hatalı Bitiş 2
        static int Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            throw new Exception("Exception");
            return 0;
        }
        #endregion
    }
}