namespace p02._01.CreatingConstructors
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            Person secondPerson = new Person(18);
            Person thirdPerson = new Person("Stamat", 43);

            Console.WriteLine(
                $"Name: {person.Name}, Age: {person.Age}");
            Console.WriteLine(
                $"Name: {secondPerson.Name}, Age: {secondPerson.Age}");
            Console.WriteLine(
                $"Name: {thirdPerson.Name}, Age: {thirdPerson.Age}");

        }
    }
}
