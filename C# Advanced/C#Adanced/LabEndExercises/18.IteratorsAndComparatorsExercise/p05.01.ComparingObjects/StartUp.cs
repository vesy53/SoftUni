namespace p05._01.ComparingObjects
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();

            while (input.Equals("END") == false)
            {
                string[] tokens = input
                    .Split();

                string name = tokens[0];
                string age = tokens[1];
                string town = tokens[2];

                Person currPerson = new Person(
                    name, 
                    age, 
                    town);

                people.Add(currPerson);

                input = Console.ReadLine();
            }

            int num = int.Parse(Console.ReadLine());

            Person person = people[num - 1];
            int equalCount = 0;

            foreach (Person element in people)
            {
                if (person.CompareTo(element) == 0)
                {
                    equalCount++;
                }
            }

            if (equalCount == 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int differentCount = people.Count - equalCount;

                Console.WriteLine(
                    $"{equalCount} {differentCount} {people.Count}");
            }
        }
    }
}
