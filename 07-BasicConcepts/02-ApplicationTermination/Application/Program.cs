namespace Application
{
    internal class Program
    {
        #region Tanım
        /*
        Uygulamanın sonlandırılması, kontrolü yürütme ortamına geri döndürür.

        Uygulamanın etkin giriş noktası metodunun dönüş türü int ise ve yürütme bir istisnaya (exception) yol açmadan tamamlanırsa, döndürülen int değişkeninin değeri
        uygulamanın sonlandırma durum kodu (termination status code) olarak görev yapar. Bu kodun amacı, başarı veya başarısızlığın yürütme ortamına iletilmesine olanak sağlamaktır.
        Etkin giriş noktası metodunun dönüş türü void ise ve yürütme bir istisnayla (exception) sonuçlanmadan tamamlanırsa sonlandırma durum kodu (termination status code) 0'dır.
        
        Etkin giriş noktası metodu bir istisna nedeniyle sona ererse, çıkış kodu uygulamaya özeldir.
        
        Sonlandırıcıların (finalizers) uygulama sonlandırmasının bir parçası olarak çalıştırılıp çalıştırılmayacağı uygulamaya özeldir.
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