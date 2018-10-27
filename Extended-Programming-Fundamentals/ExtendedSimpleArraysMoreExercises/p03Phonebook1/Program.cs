using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace p03Phonebook1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNum = Console.ReadLine()
                .Split()
                .ToArray();
            List<string> name = Console.ReadLine()
                .Split()
                .ToList();

            StringBuilder result = new StringBuilder();       

            string command = Console.ReadLine();

            while (command.Equals("done") == false)
            {
                int index = name.IndexOf(command);

                result.AppendLine($"{command} -> {phoneNum[index]}");

                command = Console.ReadLine();
            }

            Console.Write(result);
        }
    }
}
