namespace p04._01.OpinionPoll
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people.Add(person);
            }

            foreach (Person person in people
                .Where(p => p.Age > 30)
                .OrderBy(p => p.Name))
            {
                Console.WriteLine(person);
            }
        }
    }
}
