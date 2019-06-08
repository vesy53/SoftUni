namespace p05._01.RecordUniqueNames
{
    using System;
    using System.Collections.Generic;

    class RecordUniqueNames
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string>();

            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++)
            {
                string name = Console.ReadLine();

                names.Add(name);
            }
            
            Console.WriteLine(
                string.Join(Environment.NewLine, names));
        }
    }
}
