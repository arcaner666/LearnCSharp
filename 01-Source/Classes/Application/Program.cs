namespace Application;

internal abstract class Program
{
    /*
    Sınıflar (classes) C#'ta içerisinde birçok üye (member) barındırabilen veri yapılarıdır. İçerisinde sabitler (constants), alanlar (fields), metotlar (methods), özellikler 
    (properties), olaylar (events), dizinleyiciler (indexers), operatörler (operators), örnek oluşturucular (instance constructors), sonlandırıcılar (finalizers), statik oluşturucular
    (static constructors), iç içe türler (nested types) bulunabilir. Sınıflar miras almayı (inheritance) destekler. Bu özellik temel bir sınıfın (base class) genişleyerek üyelerini
    onu miras alan sınıfa (derived class) aktarmasını sağlar.
    */

    /*
    Alttaki Person sınıfı private bir sınıftır ve üç tane üyesi vardır. private bu sınıfın erişimini kapsayıcı türle (containing type) kısıtlar. Person sınıfının kapsayıcı türü Program
    sınıfıdır. Yani Person sınıfına yalnızca Program sınıfı içerisinden erişilebilir.
    */
    private class Person
    {
        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }

    private static void Main(string[] args)
    {
        var person = new Person("Arcan Caner", "Şenol", 28);
        Console.WriteLine($"My name is {person.FirstName} {person.LastName} and I am {person.Age} years old.");
    }
}