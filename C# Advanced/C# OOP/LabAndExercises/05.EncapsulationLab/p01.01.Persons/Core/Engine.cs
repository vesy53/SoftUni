namespace p01._01.Persons.Core
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Engine
    {
        public void Run()
        {
            int number = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] tokens = Console.ReadLine()
                    .Split(" ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string firstName = tokens[0];
                string lastName = tokens[1];
                int age = int.Parse(tokens[2]);

                Person person = new Person(
                    firstName,
                    lastName,
                    age);

                people.Add(person);
            }

            people.OrderBy(p => p.FirstName)
                  .ThenBy(p => p.Age)
                  .ToList()
                  .ForEach(p => Console.WriteLine(p));
        }
    }
}
