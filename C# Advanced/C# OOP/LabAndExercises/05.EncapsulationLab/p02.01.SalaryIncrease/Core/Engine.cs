namespace p02._01.SalaryIncrease.Core
{
    using System;
    using System.Collections.Generic;

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
                decimal salary = decimal.Parse(tokens[3]);

                Person person = new Person(
                    firstName,
                    lastName,
                    age,
                    salary);

                people.Add(person);
            }

            decimal percentage = decimal.Parse(Console.ReadLine());

            people.ForEach(p => p.IncreaseSalary(percentage));

            people.ForEach(p => Console.WriteLine(p));
        }
    }
}
