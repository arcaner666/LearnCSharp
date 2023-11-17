using ClassLibrary;

#region Swap Value Types
Console.WriteLine("--- Swap Value Types ---------------------------------");
static void SwapValueTypes(object first, object second)
{
    object temp = second;
    second = first;
    first = temp;
    Console.WriteLine($"Inside SwapValueTypes(a,b) => first: {first}, second: {second}");
}
int a = 5;
int b = 7;
Console.WriteLine($"Before SwapValueTypes(a,b) => a: {a}, b: {b}");
SwapValueTypes(a, b);
Console.WriteLine($"After SwapValueTypes(a,b) => a: {a}, b: {b}");
// Burada normalde iki değişkenin değerlerinin değişmesi gerekirken değişmediğini görüyoruz.
// Bunun sebebi a ve b değişkenlerinin yani int türünün bir değer tip (value type) olmasından kaynaklanıyor.
// a ve b değişkenleri Swap metodunun içerisine girerken değişkenlerin kendisi yerine içlerine aldıkları değerler gönderilir.
Console.WriteLine("------------------------------------------------------\n");
#endregion

#region Swap Value Types With ref
Console.WriteLine("--- Swap Value Types With ref ------------------------");
static void SwapValueTypesWithRef(ref int first, ref int second)
{
    int temp = second;
    second = first;
    first = temp;
    Console.WriteLine($"Inside SwapValueTypesWithRef(a,b) => first: {first}, second: {second}");
}
Console.WriteLine($"Before SwapValueTypesWithRef(a,b) => a: {a}, b: {b}");
SwapValueTypesWithRef(ref a, ref b);
Console.WriteLine($"After SwapValueTypesWithRef(a,b) => a: {a}, b: {b}");
// Burada ref deyimiyle SwapValueTypesWithRef metodu içerisine değişkenlerin değerleri yerine referanslarının gönderilmesini sağlıyoruz.
// Böylece SwapValueTypesWithRef metodu iki değişkenin değerini birbirleriyle değiştirebiliyor.
// Fakat buradaki önemli bir ayrıntı ref deyimini kullandığımız için SwapValueTypes metodundaki gibi object türünde parametre giremedik.
// Bunun sebebi metodun içerisine object türünde parametre aldığımızda metoda int dışındaki diğer türleri de atama olasılığı olduğu için
// derleyici bize bunu yapmamıza izin vermez ve ref kullanılacak parametrenin direk tipini girmemizi ister.
Console.WriteLine("------------------------------------------------------\n");
#endregion

#region Swap Reference Types
Console.WriteLine("--- Swap Reference Types -----------------------------");
static void SwapReferenceTypes(Person first, Person second)
{
    Person temp = second;
    second = first;
    first = temp;
    Console.WriteLine($"Inside SwapReferenceTypes(p1,p2) => first: {first.FirstName} {first.LastName}, second: {second.FirstName} {second.LastName}");
}
var p1 = new Person
{
    PersonId = 1,
    FirstName = "Arcan Caner",
    LastName = "Şenol",
    Age = 28,
};
var p2 = new Person
{
    PersonId = 2,
    FirstName = "Yaşar Taner",
    LastName = "Şenol",
    Age = 20,
};
Console.WriteLine($"Before SwapReferenceTypes(p1,p2) => p1: {p1.FirstName} {p1.LastName}, p2: {p2.FirstName} {p2.LastName}");
SwapReferenceTypes(p1, p2);
Console.WriteLine($"After SwapReferenceTypes(p1,p2) => p1: {p1.FirstName} {p1.LastName}, p2: {p2.FirstName} {p2.LastName}");
// Burada p1 ve p2 değişkenleri sınıf (class) türünde birer referans tiptir. Fakat burada da sonuç değişmez.
// p1 ve p2 metot içerisine girdikten sonra p1 ve p2 değişkenlerinin referansları yerine bu değişkenlerin işaret ettiği Person örneklerinin (instance) kopyaları alınır
// ve metot içerisine bu kopyalar gönderilir.
Console.WriteLine("------------------------------------------------------\n");
#endregion