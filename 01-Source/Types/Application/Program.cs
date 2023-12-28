namespace Application;

internal abstract class Program
{
    /*
    C#'ta iki çeşit tür (type) vardır. Referans tür (reference type) ve değer türü (value types). 
    
    Referans türlerin değişkenleri içlerinde verilerinin hafızadaki referanslarını tutarken değer tipi değişkenler veriyi direk içlerinde saklarlar. Referans tiplerde iki 
    değişken hafızada aynı nesneyi referans gösterebilir; bu nedenle, bir değişken üzerindeki işlemler diğer değişkenin referans gösterdiği aynı nesneyi etkileyebilir. 
    
    Değer tipinde her değişken kendi verisinin kopyasını saklar. Bir değişken üzerindeki bir işlemin diğerini etkilemesi in, ref, out deyimleri kullanılmadığı sürece mümkün değildir.

    Referans tipler:
    - class
    - interface
    - delegate
    - record

    Dahili referans tipler:
    - dynamic
    - object
    - string

    İntegral Numerik Değer Tipler:
    - sbyte
    - byte
    - short
    - ushort
    - int
    - uint
    - long
    - ulong
    - nint
    - nuint
    
    Ondalıklı Numerik Değer Tipler:
    - float
    - double
    - decimal

    Değer Tipler:
    - bool
    - char
    - Enumeration Types
    - struct
    - ref struct
    - tuple
    - nullable value types

    */
    private static void Main(string[] args)
    {
        Console.WriteLine("Reference And Value Types");
    }
}