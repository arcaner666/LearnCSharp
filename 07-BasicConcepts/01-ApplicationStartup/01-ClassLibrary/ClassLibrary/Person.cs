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