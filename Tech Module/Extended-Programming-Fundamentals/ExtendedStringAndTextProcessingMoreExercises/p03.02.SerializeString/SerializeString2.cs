namespace p03._02.SerializeString
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    class SerializeString2
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();
            
            StringBuilder builder = new StringBuilder();

            foreach (var symbol in symbols.Distinct())
            {
                builder.Append($"{symbol}:");
                //second method without StringBuilder
                //Console.Write($"{symbol}:");

                List<int> indexes = new List<int>();

                int index = symbols.IndexOf(symbol);

                while (index != -1)
                {
                    indexes.Add(index);

                    if (index + 1 > symbols.Length)
                    {
                        break;
                    }

                    index = symbols.IndexOf(symbol, index + 1);
                }

                builder.Append($"{string.Join("/", indexes)}" + Environment.NewLine);
                //Console.WriteLine(string.Join("/", indexes));
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
