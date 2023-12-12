#region Tanım
/*
Yazdığımız tüm C# kodları çalışabilmek için MSIL'e yani Microsoft Intermediate Language olarak derlenir. C# ile birlikte aynı zamanda F# ve Visual Basic dilleri de MSIL'e derlenebilirler.

Bu üç programlama dilinin her birinin kendine ait bir derleyicisi (compiler) vardır. Her bir derleyici kaynak kodları MSIL'e nasıl derleyeceğini bilir. Bu durumun getirdiği avantajlardan
biri C#'ın .NET sürümünden bağımsız olarak geliştirilebilmesidir.

C# kodları MSIL'e derlendikten sonra .NET Runtime'ı üzerinde çalışır (executing). 2023 yılı itibariyle .NET için cross-platform diyebiliriz. Şu anda .NET Runtime; Windows, Linux ve
MacOS'de çalışabilmektedir. Buna ek olarak istersek bu platformlara .NET Runtime kurmak yerine uygulamamızı runtime ile beraber de derleyebiliriz. Bu sayede uygulamamız hangi platforma
yüklenirse yüklensin hiç bir kuruluma ihtiyaç duymadan çalışabilir.
*/

Console.WriteLine("C# compiled to MSIL");
#endregion
