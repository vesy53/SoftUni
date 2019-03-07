using System;

namespace p15BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            string lastBracket = "";
            string result = "BALANCED";

            for (int i = 1; i <= num; i++)
            {
                string command = Console.ReadLine();

                if (command == "(")
                {
                    if (lastBracket == "(")
                    {
                        result = "UNBALANCED";
                        break;
                    }

                    lastBracket = "(";
                }

                if (command == ")")
                {
                    if (lastBracket != "(")
                    {
                        result = "UNBALANCED";
                        break;
                    }

                    lastBracket = ")";
                }
            }

            if (lastBracket == "(")
            {
                result = "UNBALANCED";
            }
            
            Console.WriteLine(result);          
        }
    }
}
