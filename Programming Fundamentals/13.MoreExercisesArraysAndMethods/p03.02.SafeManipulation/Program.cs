using System;
using System.Linq;

namespace p03SafeManipulation1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split(' ');

            while (true)
            {
                string[] tokens = Console.ReadLine()
                    .Split(' ');
                string command = tokens[0];

                if (command == "END")
                {
                    break;
                }

                switch (command)
                {
                    case "Reverse":
                        Array.Reverse(words);
                        break;
                    case "Distinct":
                        words = words.Distinct().ToArray();
                        break;
                    case "Replace":
                        int index = int.Parse(tokens[1]);
                        string elementToReplase = tokens[2];

                        if (index < 0 || index >= words.Length)
                        {
                            Console.WriteLine("Invalid input!");
                        }
                        else
                        {
                            words[index] = elementToReplase;
                        }

                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
