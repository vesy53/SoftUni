namespace p07._02.EqualityLogic
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            SortedSet<Person> sortedPeople = new SortedSet<Person>();
            HashSet<Person> hashPeople = new HashSet<Person>();

            int num = int.Parse(Console.ReadLine());

            while (num-- > 0)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                sortedPeople.Add(person);
                hashPeople.Add(person);
            }

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashPeople.Count);
        }
    }
}
