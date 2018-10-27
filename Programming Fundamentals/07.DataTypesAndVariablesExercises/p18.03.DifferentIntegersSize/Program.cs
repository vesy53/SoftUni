using System;
using System.Numerics;

namespace p18DifferentIntegersSize2
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger num = BigInteger.Parse(Console.ReadLine());

            string typeVariable = "";

            try
            {
                if (num < long.MinValue || num > long.MaxValue)
                {
                    Console.WriteLine($"{num} can't fit in any type");
                }
                else
                {
                    Console.Write($"{num} can fit in:");


                    if (num >= sbyte.MinValue && num <= sbyte.MaxValue)
                    {
                        // Console.WriteLine("* sbyte");
                        typeVariable += "\r\n* sbyte";
                    }
                    if (num >= byte.MinValue && num <= byte.MaxValue)
                    {
                        // Console.WriteLine("* byte");
                        typeVariable += "\r\n* byte";
                    }
                    if (num >= short.MinValue && num <= short.MaxValue)
                    {
                        //Console.WriteLine("* short");
                        typeVariable += "\r\n* short";
                    }
                    if (num >= ushort.MinValue && num <= ushort.MaxValue)
                    {
                        //Console.WriteLine("* ushort");
                        typeVariable += "\r\n* ushort";
                    }
                    if (num >= int.MinValue && num <= int.MaxValue)
                    {
                        //Console.WriteLine("* int");
                        typeVariable += "\r\n* int";
                    }
                    if (num >= uint.MinValue && num <= uint.MaxValue)
                    {
                        //Console.WriteLine("* uint");
                        typeVariable += "\r\n* uint";
                    }
                    if (num >= long.MinValue && num <= long.MaxValue)
                    {
                        //Console.WriteLine("* long");
                        typeVariable += "\r\n* long";
                    }

                    Console.WriteLine($"{typeVariable}");
                }              
            }
            catch (Exception)
            {

            }
        }
    }
}
