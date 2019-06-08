namespace p05._04.FilterByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class FilterByAge
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ",
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = input[0];
                int currAge = int.Parse(input[1]);

                Person newPerson = new Person(name, currAge);

                persons.Add(newPerson);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            Func<Person, bool> filter = FilterCondition(condition, age);
            Action<Person> result = PrintResult(format);

            foreach (Person person in persons
                .Where(filter))
            {
                result(person);
            }
        }

        static Action<Person> PrintResult(string format)
        {
            switch (format)
            {
                case "name":
                    return p => Console.WriteLine(p.Name);
                case "age":
                    return p => Console.WriteLine(p.Age);
                default:
                    return p => Console.WriteLine($"{p.Name} - {p.Age}");
            }
        }

        static Func<Person, bool> FilterCondition(
            string condition, 
            int age)
        {
            switch (condition)
            {
                case "older":
                    return p => p.Age >= age;
                case "younger":
                    return p => p.Age < age;
                default:
                    return null;
            }
        }
    }

    class Person
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}