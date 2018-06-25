using System;
using System.Linq;

namespace p03SafeManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();

            string[] command = Console.ReadLine()
                .Split();

            while (command[0] != "END")
            {
                switch (command[0])
                {
                    case "Reverse":
                        Array.Reverse(words);
                        break;
                    case "Distinct":
                        words = words.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(command[1]);
                        string elementToReplace = command[2];

                        if (index >= 0 && index < words.Length)
                        {
                            words[index] = elementToReplace;                           
                        }
                        else
                        {
                            Console.WriteLine("Invalid input!");
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
