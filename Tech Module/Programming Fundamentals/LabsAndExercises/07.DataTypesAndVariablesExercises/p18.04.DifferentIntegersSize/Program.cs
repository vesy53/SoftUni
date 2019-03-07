using System;
using System.Collections.Generic;

namespace p18DifferentIntegersSize3
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            try
            {
                long num = long.Parse(number);

                List<string> typeNumber = new List<string>();
                string sbytes = "sbyte";
                string bytes = "byte";
                string shorts = "short";
                string ushorts = "ushort";
                string ints = "int";
                string uints = "uint";
                string longs = "long";

                if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                {
                    typeNumber.Add(sbytes);
                }
                if (num >= byte.MinValue && num <= byte.MaxValue)
                {
                    typeNumber.Add(bytes);
                }
                if (num >= short.MinValue && num <= short.MaxValue)
                {
                    typeNumber.Add(shorts);
                }
                if (num >= ushort.MinValue && num <= ushort.MaxValue)
                {
                    typeNumber.Add(ushorts);
                }
                if (num >= int.MinValue && num <= int.MaxValue)
                {
                    typeNumber.Add(ints);
                }
                if (num >= uint.MinValue && num <= uint.MaxValue)
                {
                    typeNumber.Add(uints);
                }
                if (num >= long.MinValue && num <= long.MaxValue)
                {
                    typeNumber.Add(longs);
                }

                Console.WriteLine($"{number} can fit in:");

                for (int i = 0; i < typeNumber.Count; i++)
                {
                    Console.WriteLine($"* {typeNumber[i]}");
                }
            }
            catch (Exception)
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
