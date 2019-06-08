namespace p06._02.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            SortedSet<Person> peopleByName = new SortedSet<Person>(new PersonByName());
            SortedSet<Person> peopleByAge = new SortedSet<Person>(new PersonByAge());

            int num = int.Parse(Console.ReadLine());

            while (num-- > 0)
            {
                string[] arguments = Console.ReadLine()
                    .Split();

                string name = arguments[0];
                int age = int.Parse(arguments[1]);

                Person person = new Person(name, age);

                peopleByName.Add(person);
                peopleByAge.Add(person);
            }

            Console.WriteLine(string.Join(Environment.NewLine, peopleByName));
            Console.WriteLine(string.Join(Environment.NewLine, peopleByAge));
        }
    }
}
