namespace p05._03.FilterByAge
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
                    .Split(new string[] { ", " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = input[0];
                int currAge = int.Parse(input[1]);

                Person newPerson = new Person(name, currAge);

                persons.Add(newPerson);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] format = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            PrintResult(persons, condition, age, format);
        }

        static void PrintResult(
            List<Person> persons,
            string condition,
            int age,
            string[] format)
        {
            if (condition == "older")
            {
                persons = persons
                    .Where(p => p.Age >= age)
                    .ToList();
            }
            else if (condition == "younger")
            {
                persons = persons
                    .Where(p => p.Age < age)
                    .ToList();
            }

            if (format.Length == 2)
            {
                foreach (Person person in persons)
                {
                    string name = person.Name;
                    int currentAge = person.Age;

                    Console.WriteLine($"{name} - {currentAge}");
                }
            }
            else
            {
                string firstFormat = format[0];

                if (firstFormat == "name")
                {
                    foreach (Person person in persons)
                    {
                        string name = person.Name;

                        Console.WriteLine($"{name}");
                    }
                }
                else if (firstFormat == "age")
                {
                    foreach (Person person in persons)
                    {
                        int currentAge = person.Age;

                        Console.WriteLine($"{currentAge}");
                    }
                }
            }
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }
    }
}