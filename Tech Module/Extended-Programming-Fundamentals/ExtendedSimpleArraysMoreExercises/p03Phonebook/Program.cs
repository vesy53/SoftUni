using System;

namespace p03Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phoneNum = Console.ReadLine()
                .Split();
            string[] name = Console.ReadLine()
                .Split();

            string command = Console.ReadLine();

            while (command != "done")
            {
                for (int i = 0; i < name.Length; i++)
                {
                    if (command == name[i])
                    {
                        Console.WriteLine($"{name[i]} -> {phoneNum[i]}");
                        break;
                    }
                }

                command = Console.ReadLine();
            }
        }
    }
}
