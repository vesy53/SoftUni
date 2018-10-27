using System;

namespace p06DNASequences
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (char i = 'A'; i <= 'T'; i++)
            {
                for (char j = 'A'; j <= 'T'; j++)
                {
                    for (char k = 'A'; k <= 'T'; k++)
                    {
                        if ((i == 'A' || i == 'C' || i == 'G' || i == 'T') &&
                            (j == 'A' || j == 'C' || j == 'G' || j == 'T') &&
                            (k == 'A' || k == 'C' || k == 'G' || k == 'T'))
                        {
                            int counter = 0;
                            counter++;
                            int sum = i + j + k ;
                            if (i == 'A')
                            {
                                sum -= 64;                            
                            }
                            if (j == 'A')
                            {
                                sum -= 64;
                            }
                            if (k == 'A')
                            {
                                sum -= 64;
                            }
                            if (i == 'C')
                            {
                                sum -= 65;                                
                            }
                            if (j == 'C')
                            {
                                sum -= 65;
                            }
                            if (k == 'C')
                            {
                                sum -= 65;
                            }
                            if (i == 'G')
                            {
                                sum -= 68;
                            }
                            if (j == 'G')
                            {
                                sum -= 68;
                            }
                            if (k == 'G')
                            {
                                sum -= 68;
                            }
                            if (i == 'T')
                            {
                                sum -= 80;
                            }
                            if (j == 'T')
                            {
                                sum -= 80;
                            }
                            if (k == 'T')
                            {
                                sum -= 80;
                            }
                            if (sum >= number)
                            {
                                Console.Write($"O{i}{j}{k}O ");
                            }                           
                            else if (sum <= number)
                            {
                                Console.Write($"X{i}{j}{k}X ");
                            }
                            if (counter % 4 == 0)
                            {
                                Console.WriteLine();
                            }
                        }
                     
                    }
                }
            }
        }
    }
}
