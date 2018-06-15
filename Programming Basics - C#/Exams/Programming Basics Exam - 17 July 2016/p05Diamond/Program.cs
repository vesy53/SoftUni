using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p05Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int width = 5 * num;
            int height = 3 * num + 2;

            Console.WriteLine("{0}{1}{0}", 
                new string('.', num),
                new string('*', 3 * num));

            int outDots = num - 1;
            int innerDots = 3 * num;

            for (int i = 1; i < num; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', outDots),
                    new string('.', innerDots));

                outDots--;
                innerDots += 2;
            }

            Console.WriteLine(new string('*', width));

            innerDots = width - 4;

            for (int i = 1; i <= num * 2; i++)
            {
                Console.WriteLine("{0}*{1}*{0}",
                    new string('.', i),
                    new string('.', innerDots));

                innerDots -= 2;
            }

            Console.WriteLine("{0}{1}{0}",
                new string('.', num * 2 + 1),
                new string('*', width - 2 * (2 * num + 1)));
        }
    }
}
