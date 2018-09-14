namespace p01._01.OrderByAge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class OrderByAge
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<Person> persons = new List<Person>();

            while (input.Equals("End") == false)
            {
                string[] inputTokens = input
                    .Split();

                string name = inputTokens[0];
                string id = inputTokens[1];
                int age = int.Parse(inputTokens[2]);

                Person newPerson = new Person
                (
                    name,
                    id,
                    age
                );

                persons.Add(newPerson);

                input = Console.ReadLine();
            }

            persons = persons
                .OrderBy(x => x.Age)
                .ToList();

            foreach (Person person in persons)
            {
                string name = person.Name;
                string id = person.ID;
                int age = person.Age;

                Console.WriteLine(
                    $"{name} with ID: {id} is {age} years old.");
            }
        }
    }

    class Person
    {
        public string Name { get; set; }

        public string ID { get; set; }

        public int Age { get; set; }

        public Person(
            string name,
            string id,
            int age)
        {
            this.Name = name;
            this.ID = id;
            this.Age = age;
        }
    }
}
