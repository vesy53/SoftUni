using System;

namespace p09CountTheIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            try
            {
                while (true)
                {
                    int num = int.Parse(Console.ReadLine());

                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);            
            }
        }
    }
}
