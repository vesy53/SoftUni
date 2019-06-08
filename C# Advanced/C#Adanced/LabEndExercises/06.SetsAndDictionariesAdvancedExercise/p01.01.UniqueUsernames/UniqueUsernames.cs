namespace p01._01.UniqueUsernames
{
    using System;
    using System.Collections.Generic;

    class UniqueUsernames
    {
        static void Main(string[] args)
        {
            HashSet<string> data = new HashSet<string>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();

                data.Add(name);
            }

            Console.WriteLine(
                string.Join(Environment.NewLine, data));
        }
    }
}
