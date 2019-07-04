namespace p01._02.Person.Core
{
    using System;

    using p01._02.Person.Persons;

    public class Engine
    {
        public void Run()
        {
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            try
            {
                Child child = new Child(name, age);
                Console.WriteLine(child);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
        }
    }
}
