#region Üye Erişimleri (Members Access)

#region Genel (General)
/*
Üyelerin (members) tanımlanmaları üye erişimi üzerinde kontrol sağlar. Bir üyenin erişilebilirliği, üyenin tanımlanan erişim bildirgeciyle (§7.5.2) ve varsa onu kapsayan 
türün erişim bildirgecinin kombinasyonuna göre belirlenir.

Belirli bir üyeye erişime izin verildiğinde üyenin erişilebilir (accessible) olduğu söylenir. Tersine, belirli bir üyeye erişime izin verilmediğinde üyenin erişilemez (inaccessible) 
olduğu söylenir. Erişimin gerçekleştiği metinsel konum, üyenin erişilebilirlik alanına (accessibility domain) (§7.5.3) dahil edildiğinde, bir üyeye erişime izin verilir.
*/
#endregion

#region Tanımlanmış Erişilebilirlik (Declared Accessibility)
/*
Bir üyenin tanımlanan erişilebilirliği aşağıdakilerden biri olabilir:
*/

#region public
/*
Bir üye tanımına public deyimi eklenerek işaretlenir. public deyimi "erişime kapalı değil" demektir.

!!! ReSharper bozuyor açma !!!
*/
// N1 ad uzayındaki Person sınıfı public olarak tanımlanmış. Dolayısıyla using N1; ifadesi dahil edildiğinde Application ad uzayından erişilebiliyor. Aynı şekilde Person sınıfındaki
// NameSurname alanı public olduğu için konsola yazdırılabiliyor. 
//using N1;
//namespace N1
//{
//    public class Person
//    {
//        public string NameSurname { get; set; }
//        public Person(string nameSurname)
//        {
//            NameSurname = nameSurname;
//        }
//    }
//}
//namespace Application
//{

//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            var person = new Person("Arcan Caner Şenol");
//            Console.WriteLine($"Name Surname: {person.NameSurname}");
//        }
//    }
//}
#endregion

#region protected
/*
Bir üye tanımına protected deyimi eklenerek işaretlenir. protected deyimi "erişim kapsayıcı sınıf veya bu kapsayıcı sınıftan türetilen sınıflarla kısıtlı" demektir.
*/

//namespace Application
//{
//    public class Person
//    {
//        protected string Name { get; set; } = "Arcan Caner";
//        protected string Surname { get; set; } = "Şenol";
//    }
//    public class Customer : Person
//    {
//        public string NameSurname { get; set; }
//        public Customer()
//        {
//            NameSurname = Name + Surname;
//        }
//        // Üstteki gibi sadece oluşturucu içerisinden temel sınıftaki protected alanlara erişebiliyoruz. Alttaki satır hata verir.
//        //var name = Name;
//    }
//    public class Program
//    {
//        static void Main(string[] args)
//        {
//            var customer = new Customer();
//            Console.WriteLine($"Name Surname: {customer.NameSurname}");
//            customer.NameSurname = "Yaşar Taner Şenol";
//            // Person içerisindeki Name alanı protected erişim bildirgecine sahip olduğundan erişilemiyor. Alttaki satır hata verir.
//            //customer.Name = "Yaşar Taner";
//        }
//    }
//}
#endregion

#region internal
/*
Bir üye tanımına internal deyimi eklenerek işaretlenir. internal deyimi "erişim bu program (assembly) ile sınırlı" demektir.
*/
#endregion

#region protected internal
/*
Bir üye tanımına protected internal deyimi eklenerek işaretlenir. protected internal deyimi deyimi "erişim aynı program (assembly) içerisinden ve kapsayıcı
sınıftan (containing class) türetilen sınıflarla (derived class) kısıtlı" demektir.
*/
#endregion

#region private protected
/*
Bir üye tanımına private protected deyimi eklenerek işaretlenir. private protected deyimi deyimi "erişim aynı program (assembly) içerisindeki kapsayıcı sınıf (containing class) veya
bu kapsayıcı sınıftan türetilen sınıflarla (derived class) kısıtlı" demektir.
*/
#endregion

#region private
/*
Bir üye tanımına private deyimi eklenerek işaretlenir. private deyimi deyimi "erişim aynı kapsayıcı türle (containing type) kısıtlı" demektir.
*/
#endregion

/*
Üyenin tanımlandığı bağlama bağlı olarak, yalnızca belirli türde erişim bildirgeci kullanılmasına izin verilir. Ayrıca, bir üye tanımında herhangi bir erişim bildirgeci bulunmadığı
durumda içinde bulunulan bağlama göre bir varsayılan erişim bildirgeci eklenir.
*/

#region Durum 1
/*
Ad uzayları örtülü olarak public erişim bildirgecine sahiptir. Ad uzayları tanımlamalarında hiçbir erişim bildirgeci eklenmesine izin verilmez.
*/
#endregion

#region Durum 2
/*
Derleme birimlerinde (compilation units) veya ad uzaylarının (namespaces) direk içerisinde yer alan türler (types) public ve internal erişim bildirgecine sahip olabilir. Varsayılan
internal erişim bildirgecidir.
*/
#endregion

#region Durum 3
/*
Sınıf üyeleri (class members), herhangi bir türdeki erişim bildirgecini alabilirler. Varsayılan private erişim bildirgecidir.

Sınıf içerinde tanımlanan üyeler tüm erişim bildirgeçlerini alabilirken, ad uzayları (namespace) içerisindeki üyeler yalnızca public veya internal erişim bildirgeçlerini alabilirler.
*/
#endregion

#region Durum 4
/*
Yapı üyeleri (struct members), public, internal veya private erişim bildirgeçlerini alabilirler. Varsayılan private erişim bildirgecidir çünkü yapılar gizli olarak sealed deyimi
alırlar. sealed deyimi eklendiği türden yeni bir örnek oluşturulmasını engeller.
*/
#endregion

#region Durum 5
/*
Arayüzler (interfaces) gizli olarak public erişim bildirgecini alır. Arayüzlere erişim bildirgeci eklenmesine izin verilmez.
*/
#endregion

#region Durum 6
/*
Sayılabilirler (enumerable) gizli olarak public erişim bildirgecini alır. Sayılabilirlere erişim bildirgeci eklenmesine izin verilmez.
*/
#endregion

#endregion

#region Erişilebilirlik Alanları (Accessibility Domains)
namespace Application
{
    public class A
    {
        public static int X = 0;
        internal static int Y = 1;
        private static int Z = 2;
    }

    internal class B
    {
        public static int X = 0;
        internal static int Y = 1;
        private static int Z = 2;

        public class C
        {
            public static int X = 0;
            internal static int Y = 1;
            private static int Z = 2;
        }

        private class D
        {
            public static int X = 0;
            internal static int Y = 1;
            private static int Z = 2;
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            var a = new A();
            Console.WriteLine(A.X);
        }
    }
}
#endregion
#endregion
