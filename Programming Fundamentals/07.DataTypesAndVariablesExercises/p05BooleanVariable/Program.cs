using System;

namespace p05BooleanVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();

            bool isTrue = Convert.ToBoolean(word);

            if (isTrue)
            {
                Console.WriteLine("Yes");           
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
