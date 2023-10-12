// Bu proje bir Class Library'dir. Direk olarak başlatılamaz veya çalıştırılamaz fakat
// başka class library'lerden veya application'lar tarafından referans gösterilerek
// çağrılabilir ve içindeki property'lere ve metotlara izin verilmesi halinde erişilebilir.
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