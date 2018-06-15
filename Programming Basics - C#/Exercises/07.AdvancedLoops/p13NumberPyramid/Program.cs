using System;

namespace p13NumberPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 0;

            if (num == 1)
            {
                Console.WriteLine("1");
            }

            for (int i = 2; i <= num; i++)
            {            
                for (int j = 1; j < i; j++)
                {
                    count++;
                    if (count <= num)
                    {
                        Console.Write(count + " ");                    
                    }

                    if (num == 2)
                    {
                        Console.WriteLine("\r\n2");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
