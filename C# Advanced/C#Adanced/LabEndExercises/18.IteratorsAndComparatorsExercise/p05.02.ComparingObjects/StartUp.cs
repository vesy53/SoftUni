namespace p05._02.ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] arguments = input
                    .Split();

                string name = arguments[0];
                int age = int.Parse(arguments[1]);
                string town = arguments[2];

                Person person = new Person(name, age, town);

                people.Add(person);

                input = Console.ReadLine();
            }

            int index = int.Parse(Console.ReadLine());

            Person comparePerson = people[index - 1];

            int equalPeople = 0;

            foreach (var person in people)
            {
                if (person.CompareTo(comparePerson) == 0)
                {
                    equalPeople++;
                }
            }

            if (equalPeople > 1)
            {
                Console.WriteLine(
                    $"{equalPeople} {people.Count - equalPeople} {people.Count}");
            }
            else // if (equalPeople == 1)
            {
                Console.WriteLine("No matches");
            }
        }
    }
}
