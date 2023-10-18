/*
Bu proje bir sınıf kitaplığıdır (class library). Direk olarak başlatılamaz veya çalıştırılamaz fakat başka sınıf kitaplıklarından veya uygulamalar (applications)
tarafından referans gösterilerek çağrılabilir ve içindeki üyelere (members) izin verilmesi halinde erişilebilir.
*/
namespace ClassLibrary
{
    public class Person
    {
        public string name = "Arcan Caner";
        public int age = 28;

        public string Greeting()
        {
            return $"{name} is {age} year old.";
        }
    }
}