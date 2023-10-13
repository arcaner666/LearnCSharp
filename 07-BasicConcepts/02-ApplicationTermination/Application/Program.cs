/*
Uygulamanın sonlandırılması, kontrolü yürütme ortamına geri döndürür.

Uygulamanın etkin giriş noktası metodunun dönüş türü int ise ve yürütme bir istisnaya (exception) yol açmadan tamamlanırsa, döndürülen int'nin değeri 
uygulamanın sonlandırma durum kodu (termination status code) olarak görev yapar. Bu kodun amacı, başarı veya başarısızlığın yürütme ortamına iletilmesine olanak sağlamaktır.
Etkin giriş noktası metodunun dönüş türü void ise ve yürütme bir istisnayla (exception) sonuçlanmadan tamamlanırsa sonlandırma durum kodu (termination status code) 0'dır.
Etkin giriş noktası metodu bir istisna nedeniyle sona ererse, çıkış kodu uygulamaya özeldir.
Sonlandırıcıların (finalizers) uygulama sonlandırmasının bir parçası olarak çalıştırılıp çalıştırılmayacağı uygulamaya özeldir.
*/
namespace Application
{
    internal class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            return 0;
        }
    }
}