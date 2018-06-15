using System;

namespace p06NumberGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int specialNum = int.Parse(Console.ReadLine());
            int controlNum = int.Parse(Console.ReadLine());

            for (int i = num1; i >= 1; i--)
            {
                for (int j = num2; j >= 1; j--)
                {
                    for (int k = num3; k >= 1; k--)
                    {
                        int total = i * 100 + j * 10 + k;

                        if (total % 3 == 0)
                        {
                            specialNum += 5;
                        }
                        else if (total % 10 == 5)
                        {
                            specialNum -= 2;
                        }
                        else if (total % 2 == 0)
                        {
                            specialNum *= 2;
                        }

                        if (specialNum >= controlNum)
                        {                        
                            break;
                        }
                    }

                    if (specialNum >= controlNum)
                    {
                        break;
                    }
                }

                if (specialNum >= controlNum)
                {
                    break;
                }
            }

            if (specialNum < controlNum)
            {
                Console.WriteLine
                    ($"No! {specialNum} is the last reached special number.");
            }
            else if (specialNum >= controlNum)
            {
                Console.WriteLine(
                              $"Yes! Control number was reached! " +
                              $"Current special number is {specialNum}.");
            }
        }
    }
}
