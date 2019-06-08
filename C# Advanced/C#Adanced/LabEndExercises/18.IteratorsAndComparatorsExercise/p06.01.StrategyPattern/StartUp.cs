namespace p06._01.StrategyPattern
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            SortedSet<Person> sortedName = new SortedSet<Person>(new NameComparer());
            SortedSet<Person> sortedAge = new SortedSet<Person>(new AgeComparer());

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                sortedName.Add(person);
                sortedAge.Add(person);
            }
            
            Console.WriteLine(string.Join(Environment.NewLine, sortedName));
            Console.WriteLine(string.Join(Environment.NewLine, sortedAge));
        }
    }
}
