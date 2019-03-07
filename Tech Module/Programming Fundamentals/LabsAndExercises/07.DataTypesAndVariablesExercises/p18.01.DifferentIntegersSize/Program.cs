using System;

namespace p18DifferentIntegersSize
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            string type = "";
            bool canFit = false;

            try
            {
                sbyte num = sbyte.Parse(number);
                type += "\r\n* sbyte";
                canFit = true;
            }
            catch (Exception)
            { }

            try
            {
                byte num = byte.Parse(number);
                type += "\r\n* byte";
                canFit = true;
            }
            catch (Exception)
            { }

            try
            {
                short num = short.Parse(number);
                type += "\r\n* short";
                canFit = true;
            }
            catch (Exception)
            { }

            try
            {
                ushort num = ushort.Parse(number);
                type += "\r\n* ushort";
                canFit = true;
            }
            catch (Exception)
            { }

            try
            {
                int num = int.Parse(number);
                type += "\r\n* int";
                canFit = true;
            }
            catch (Exception)
            { }

            try
            {
                uint num = uint.Parse(number);
                type += "\r\n* uint";
                canFit = true;
            }
            catch (Exception)
            { }

            try
            {
                long num = long.Parse(number);
                type += "\r\n* long";
                canFit = true;
            }
            catch (Exception)
            { }

            if (canFit)
            {
                Console.WriteLine($"{number} can fit in: {type}");
            }
            else
            {
                Console.WriteLine($"{number} can't fit in any type");
            }
        }
    }
}
