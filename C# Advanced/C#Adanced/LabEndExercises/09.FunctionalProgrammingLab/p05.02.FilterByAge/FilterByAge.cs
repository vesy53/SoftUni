namespace p05._02.FilterByAge
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class FilterByAge
    {
        static void Main(string[] args)
        {
            var peoples = new List<KeyValuePair<string, int>>();

            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(new string[] { ", " },
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string name = input[0];
                int currAge = int.Parse(input[1]);

                peoples
                    .Add(new KeyValuePair<string, int>(name, currAge));
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries);

            peoples
                .Where(p => condition == "younger" ?
                    p.Value < age :
                    p.Value >= age)
                .ToList()
                .ForEach(p => Printer(p, commands));
        }

        static void Printer(
            KeyValuePair<string, int> peoples,
            string[] commands)
        {
            if (commands.Length == 2)
            {
                Console.WriteLine(commands[0] == "name" ?
                    $"{peoples.Key} - {peoples.Value}" :
                    $"{peoples.Value} - {peoples.Key}");
            }
            else
            {
                Console.WriteLine(commands[0] == "name" ?
                    $"{peoples.Key}" :
                    $"{peoples.Value}");
            }
        }
    }
}