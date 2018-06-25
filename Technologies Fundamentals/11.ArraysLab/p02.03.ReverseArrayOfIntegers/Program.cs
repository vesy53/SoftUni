using System;
using System.Collections.Generic;

namespace p02ReverseArrayOfIntegers2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<int> listNum = new List<int>();

            for (int i = 0; i < number; i++)
            {
                int num = int.Parse(Console.ReadLine());

                listNum.Add(num);
            }

            listNum.Reverse();

            foreach (var list in listNum)
            {
                Console.Write(list + " ");
            }

            //Second method per print
            //Console.WriteLine(string.Join(" ", listNum));
        }
    }
}
