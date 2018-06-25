using System;
using System.Linq;

namespace p02ManipulateArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] command = Console.ReadLine()
                    .Split();

                if (command[0] == "Reverse")
                {
                    Array.Reverse(words);
                    continue;
                }
                else if (command[0] == "Distinct")
                {
                    words =  words.Distinct().ToArray();
                    continue;
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    string elementToReplace = command[2];
                    words[index] = elementToReplace;
                    continue;
                }
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
