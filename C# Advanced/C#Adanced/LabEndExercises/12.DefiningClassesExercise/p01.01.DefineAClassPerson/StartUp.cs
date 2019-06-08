namespace p01._01.DefineAClassPerson
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person("Pesho", 20);
            Person secondPerson = new Person("Gosho", 18);
            Person thirdPerson = new Person("Stamat", 45);

            Console.WriteLine(
                $"Name: {person.Name}, Age: {person.Age}");
            Console.WriteLine(
                $"Name: {secondPerson.Name}, Age: {secondPerson.Age}");
            Console.WriteLine(
                $"Name: {thirdPerson.Name}, Age: {thirdPerson.Age}");
        }
    }
}
