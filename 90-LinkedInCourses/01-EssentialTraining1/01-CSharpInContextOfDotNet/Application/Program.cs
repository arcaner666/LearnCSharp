#region MSIL ve ILDASM
/*
Yazdığımız tüm C# kodları çalışabilmek için MSIL'e yani Microsoft Intermediate Language olarak derlenir. C# ile birlikte aynı zamanda F# ve Visual Basic dilleri de MSIL'e derlenebilirler.

Bu üç programlama dilinin her birinin kendine ait bir derleyicisi (compiler) vardır. Her bir derleyici kaynak kodları MSIL'e nasıl derleyeceğini bilir. Bu durumun getirdiği avantajlardan
biri C#'ın .NET sürümünden bağımsız olarak geliştirilebilmesidir.

Bir programın çevrildiği MSIL dosyasını incelemek istiyorsak Ildasm.exe adlı programı kullanabiliriz. Açılımı Intermediate Language Disassembler olan bu program C# kodumuzun dönüştüğü
MSIL dosyasını görüntülememizi sağlar.

Ildasm.exe'yi C:\Program Files(x86)\Microsoft SDKs\Windows\v10.0A\bin\NETFX 4.8 Tools içerisinde bulabiliriz.

C# kodları MSIL'e derlendikten sonra .NET Runtime'ı üzerinde çalışır (executing). 2023 yılı itibariyle .NET için cross-platform diyebiliriz. Şu anda .NET Runtime; Windows, Linux ve
MacOS'de çalışabilmektedir. Buna ek olarak istersek bu platformlara .NET Runtime kurmak yerine uygulamamızı runtime ile beraber de derleyebiliriz. Bu sayede uygulamamız hangi platforma
yüklenirse yüklensin hiç bir kuruluma ihtiyaç duymadan çalışabilir.
*/

Console.WriteLine("C# compiled to MSIL");
#endregion

#region Base Class Library
/*
C#, F# ve Visual Basic; .NET Runtime içerisinde bulunan Base Class Library adı verilen ortak kütüphaneleri kullanırlar. Bu kütüphaneler veri türleri, matematik fonksiyonları, 
ağ fonksiyonları, dosya erişim sınıfları, güvenlik, veri erişim sınıfları gibi şeyleri içerir.

Kendi geliştirdiğimiz sınıflar, üçüncü taraf yazılımları ve Microsoft'un kendi kütüphaneleri bu Base Class Library'i kullanır. Uygulama seviyesinde herşeyin üzerinde çalıştığı
en alt tabakadır diyebiliriz.
*/
#endregion

#region NuGet
/*
C# ve .NET ortamı için; üçüncü taraf yazılımlarına ve Microsoft'un kendi kütüphanelerine erişebileceğimiz büyük bir paket yöneticisidir (package manager). NuGet.org ise tüm bu
kütüphaneleri barındıran platformdur (repo hosting platform).
*/
#endregion