#region Üyeler (Members)

#region Genel
/*
Ad uzayları (namespace) ve türlerin (types) üyeleri (members) vardır. Bir varlığın üyesine erişmek için genel olarak entity adından sonra bir . konur ardında 
üyenin adı yazılır. Bu şekilde bir varlığın üyesine erişiriz.

Bir türün üyeleri ya türün içerisinde ya da bu türün temel sınıfında tanımlanır. Bir tür temel sınıfından miras aldığında, örnek oluşturucular (instance constructors),
sonlandırıcılar (finalizers) ve statik oluşturucular (static constructors) dışında temel sınıfın tüm üyeleri, türetilen türün üyeleri haline gelir.

Bir temel sınıftaki üyenin erişim bildirgeci, üyenin miras alınıp alınmadığını denetlemez. Erişim bildirgeçleri örnek oluşturucu, statik oluşturucu veya sonlandırıcı 
olmayan tüm üyelere yayılır.

Yine de, temel bir sınıf içerisindeki bir üyeye üzerinde tanımlanan erişim bildirgeci sebebiyle türetildiği sınıftan erişilemeyebilir. 
*/

public class Ages
{
    public int Age { get; set; } = 16;
}

public class Application<T>
{
    public string Show1()
    {
        return $"The type is {typeof(T)}.";
    }
}

namespace Application
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var showAges = new Application<Ages>();
            Console.WriteLine(showAges.Show1());
        }
    }
}
#endregion

#endregion