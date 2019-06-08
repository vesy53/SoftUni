namespace p10._01.PredicateParty
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class PredicateParty
    {
        static void Main(string[] args)
        {
            List<string> peoples = Console.ReadLine()
                .Split(' ',
                    StringSplitOptions
                    .RemoveEmptyEntries)
                .ToList();
            string input = Console.ReadLine();

            while (input.Equals("Party!") == false)
            {
                string[] tokens = input
                    .Split(' ',
                        StringSplitOptions
                        .RemoveEmptyEntries);

                string command = tokens[0];
                string secondCommand = tokens[1];
                string parameter = tokens[2];

                Func<string, bool> commandFunc = c => c == "Remove";

                if (commandFunc(command))
                {
                    Func< List<string>, string, string, List<string>> removeFunc = 
                        RemoveElementeFromTheList;
                    removeFunc(peoples, secondCommand, parameter);
                }
                else
                {
                    Func<List<string>, string, string, List<string>> duplicateFunc = 
                        DuplicateElementeFromTheList;
                    duplicateFunc(peoples, secondCommand, parameter);
                }

                input = Console.ReadLine();
            }

            Func<List<string>, bool> resultFunc = p => p.Count == 0;
            Action<string> printEmptyList = p => 
                Console.WriteLine("Nobody is going to the party!");
            Action<List<string>> print = p => 
                Console.WriteLine($"{string.Join(", ", p)} are going to the party!");

            if (resultFunc(peoples))
            {
                printEmptyList("");
            }
            else
            {
                print(peoples);
            }
        }

        private static List<string> DuplicateElementeFromTheList(
            List<string> peoples, 
            string command, 
            string parameter)
        {
            if (command == "StartsWith")
            {
                Func<string, bool> funcStartsWith = s => s.StartsWith(parameter);

                DuplicateElement(peoples, parameter, funcStartsWith);
            }
            else if (command == "EndsWith")
            {
                Func<string, bool> funcEndsWith = s => s.EndsWith(parameter);

                DuplicateElement(peoples, parameter, funcEndsWith);
            }
            else if (command == "Length")
            {
                Func<string, bool> funcEndsWith = s => s.Length == int.Parse(parameter);

                DuplicateElement(peoples, parameter, funcEndsWith);
            }

            return peoples;
        }

        private static void DuplicateElement(
            List<string> peoples, 
            string parameter, 
            Func<string, bool> function)
        {
            for (int i = 0; i < peoples.Count; i++)
            {
                if (function(peoples[i]))
                {
                    peoples.Insert(i + 1, peoples[i]);
                    i++;
                }
            }
        }

        private static List<string> RemoveElementeFromTheList(
            List<string> peoples, 
            string  command, 
            string parameter)
        {
            if (command == "StartsWith")
            {
                Func<string, bool> funcStartsWith = s => s.StartsWith(parameter);

                RemoveElement(peoples, parameter, funcStartsWith);
            }
            else if (command == "EndsWith")
            {
                Func<string, bool> funcEndsWith = s => s.EndsWith(parameter);

                RemoveElement(peoples, parameter, funcEndsWith);
            }
            else if (command == "Length")
            {
                Func<string, bool> funcEndsWith = s => s.Length == int.Parse(parameter);

                RemoveElement(peoples, parameter, funcEndsWith);
            }

            return peoples;
        }

        private static void RemoveElement(
            List<string> peoples, 
            string parameter, 
            Func<string, bool> function)
        {
            for (int i = 0; i < peoples.Count; i++)
            {
                if (function(peoples[i]))
                {
                    peoples.Remove(peoples[i]);
                    i--;
                }
            }
        }
    }
}
