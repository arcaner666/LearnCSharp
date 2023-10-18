using ClassLibrary;

namespace Application
{
    internal class Program
    {
        #region Tanım
        /*
        Bir program, diğer uygulamaların bir parçası olarak kullanılacak bir sınıf kitaplığı (class library) olarak veya doğrudan başlatılabilen bir uygulama (executable/application)
        olarak derlenebilir (compiling). Bu derleme şeklini belirleme mekanizması uygulamaya özeldir ve bu belgenin kapsamı dışındadır.

        C#'ta bir programın uygulama (executable/application) olarak derlenebilmesi için içerisinde bulunan en az bir metodun alttaki şartları karşılaması gerekir:
        - Main adını taşımalı
        - static olmalı
        - generic olmayan bir türde tanımlanmalı
        - Eğer tanımladığı tür iç içe tanımlanmış (nested) bir türse onu kapsayan türlerin hiçbiri generic olamaz
        - Dönüş türünün System.Threading.Tasks.Task veya System.Threading.Tasks.Task int olması durumunda async bildirgecine sahip olabilir.
        - Dönüş türü void, int, System.Threading.Tasks.Task veya System.Threading.Tasks.Task int olmalı
        - İmplement edilmemiş bir partial metot olamaz
        - Parametre olarak ya boş olmalı ya da string[] türünde tek bir parametreye sahip olmalıdır.
           
        Genelde bir metodun veya türün (type) erişilebilirliği tanımındaki erişim bildirgecine (access modifier) bağlıdır. Bir tür içerisindeki bir metodun çağrılabilmesi için hem 
        türün hem de metodun erişim bildirgecinin uygun olması gerekir. Ancak uygulamanın başlangıç noktasında (application entry point) böyle bir durum söz konusu değildir. Spesifik 
        olarak çalışma ortamı (execution environment) metot tanımında belirtilen erişim bildirgecinden veya metodu kapsayan türün erişim bildirgecinden bağımsız olarak bu metoda 
        erişebilir.
        
        Eğer başlangıç metodunun dönüş türü System.Threading.Tasks.Task, ya da System.Threading.Tasks.Task<int> ise derleyici bu metodu çağıran yeni senkron bir metot sentezler. Bu 
        kapsayıcı metodun dönüş türü de System.Threading.Tasks.Task için void, System.Threading.Tasks.Task<int> içinse int olur. Bu sentezlenen metodun çalışma şekli aşağıdaki gibidir:
        - Sentezlenen metot Main metodunu çağırır, içinde gelen string[] parametresini eğer Main metodunda da böyle bir parametre varsa ona parametre olarak girer.
        - Eğer Main metodu bir istisna (exception) döndürürse sentezlenen metot da bu istisnayı döndürür.
        - Diğer durumda sentezlenen metot Main metodundan dönen sonucu bekler, Task üzerindeki GetAwaiter().GetResult metotlarını parametreli veya parametre girmeden çağırır.
        Eğer Task hata döndürürse bu hata sentezlenen metot da döndürülür.
        - System.Threading.Tasks.Task<int> döndüren Main metodu ise başarılı olduğunda sentezlenen metoda int döndürür.
        
        Bir uygulamanın efektif başlangıç noktası (the effective entry point) ya kurallara uygun bir Main metodudur ya da üstteki gibi sentezlenmiş bir metottur. Efektif başlangıç 
        noktası her zaman ya void ya da int döndürür.
        
        Bir uygulama çalışmaya başladığında yeni bir uygulama etki alanı (application domain) oluşturulur. Bir cihazda aynı anda aynı uygulama birden fazla kez çalıştırılabilir ve
        her çalıştırma için ayrı bir uygulama etki alanı oluşturulur. Uygulama etki alanı uygulamaların farklı oturumlarını birbirinden izole eder ve uygulamanın durumunun 
        (application state) korunmasını sağlar. Bir uygulama etki alanı, uygulamada tanımlanan türler ve kullandığı sınıf kitaplıkları için bir kapsayıcı ve sınır görevi görür.
        Bir uygulama etki alanına yüklenen türler, başka bir uygulama etki alanına yüklenen türlerden farklıdır ve nesnelerin örnekleri, uygulama etki alanları arasında doğrudan
        paylaşılmaz. Örneğin, her uygulama etki alanı, bu türler için kendi static değişken kopyalarına sahiptir ve bir tür için static constructor her uygulama etki alanında 
        en fazla bir kez çalıştırılır.

        Uygulama, yürütme ortamı (execution environment) uygulamanın etkin giriş noktasını (effective entry point) çağırdığında başlar. Etkin giriş noktası bir parametreye sahipse, 
        uygulamanın başlatılması sırasında, bu parametrenin boş olmayan (non-null) bir string dizisi olmadığından emin olur. Bu dizi, uygulama başlatılmadan önce yürütme ortamı
        tarafından uygulama girilir ve bu diziye uygulama parametreleri (application parameters) adı verilir. Burada amaç, uygulama başlatılmadan önce uygulamaya ortam dışından bir 
        girdi sağlayabilmektir.
        
        Etkin giriş noktasının dönüş türü int ise, buradan dönen değer, uygulamanın sonlandırılmasında kullanılır.
        
        Yukarıda sayılan durumlar dışında giriş noktası her bakımdan normal metotlar gibi davranır. Özellikle, giriş noktası uygulamanın ömrü boyunca herhangi bir noktada tekrar
        çağrılırsa herhangi özel bir etkiye sebep olmaz. Örneğin; bir parametresi varsa, başlangıç değeri null olabilir veya null referanslar içeren bir diziye referans gösterebilir.
        Benzer şekilde, giriş noktasının dönüş değerinin, yürütme ortamından yapılan çağrı dışında özel bir önemi yoktur.
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