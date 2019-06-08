﻿namespace p03._01.OldestFamilyMember
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < number; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                family.AddMember(person);
            }

            Person oldestPerson = family.GetOldestMember();

            Console.WriteLine(
                $"{oldestPerson.Name} {oldestPerson.Age}");
        }
    }
}
