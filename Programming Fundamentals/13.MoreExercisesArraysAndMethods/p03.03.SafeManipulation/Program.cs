using System;
using System.Linq;

namespace p03SafeManipulation2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');
            string[] command = Console.ReadLine()
                .Split(' ');

            while (command[0] != "END")
            {
                if (command[0] == "Reverse")
                {
                    Array.Reverse(words);
                }
                else if (command[0] == "Distinct")
                {
                    words = words.Distinct().ToArray();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);

                    if (index < 0 || index > words.Length - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        string elementToReplace = command[2];
                        words[index] = elementToReplace;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine().Split(' ');
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
