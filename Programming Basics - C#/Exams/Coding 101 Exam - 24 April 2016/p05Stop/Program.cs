using System;

namespace p05Stop
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("{0}{1}{0}",
                new string('.', num + 1),
                new string('_', num * 2 + 1));

            int dots = num;
            int dashes = num * 2 - 1;

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', dots),
                    new string('_', dashes));
                dots--;
                dashes += 2;
            }

            Console.WriteLine("//{0}STOP!{0}\\\\",
              new string('_', 2 * num - 3));

            dashes = num * 4 - 1;

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', i),
                    new string('_', dashes));
                dashes -= 2;
            }
        }
    }
}
